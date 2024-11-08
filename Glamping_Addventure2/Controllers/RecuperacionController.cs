using Glamping_Addventure2.Models;
using Glamping_Addventure2.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace Glamping_Addventure2.Controllers
{
    // Eliminamos el prefijo api para las acciones que no sean parte de una API RESTful
    [Route("Recuperacion/[action]")]
    public class RecuperacionController : Controller
    {
        private readonly GlampingAddventureContext _context;
        private readonly IEmailService _emailService;

        public RecuperacionController(GlampingAddventureContext context, IEmailService emailService)
        {
            _context = context;
            _emailService = emailService;
        }

        // Acción para mostrar la vista de solicitar recuperación de contraseña
        [HttpGet("SolicitarRecuperacion")]
        public IActionResult SolicitarRecuperacion()
        {
            return View();  // Verifica que la vista esté en la ruta correcta
        }

        // Solicitar recuperación de contraseña (POST)
        [HttpPost("enviar-recuperacion")]
        public async Task<IActionResult> EnviarRecuperacion([FromForm] string email)
        {
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                return BadRequest("El correo electrónico no tiene un formato válido.");
            }

            var usuario = await _context.Usuarios.FirstOrDefaultAsync(u => u.Email == email);
            if (usuario == null)
            {
                return BadRequest("El correo electrónico no está registrado.");
            }

            var token = Guid.NewGuid().ToString();
            var tokenRecuperacion = new TokenRecuperacion
            {
                UsuarioId = usuario.Idusuario,
                Token = token,
                FechaExpiracion = DateTime.Now.AddHours(1)
            };

            _context.TokenRecuperacion.Add(tokenRecuperacion);
            await _context.SaveChangesAsync();

            var recoveryLink = Url.Action("Recuperar", "Recuperacion", new { token }, Request.Scheme);
            var subject = "Recuperación de Contraseña";
            var message = $"Haz clic en el siguiente enlace para recuperar tu contraseña: <a href='{recoveryLink}'>Recuperar Contraseña</a>";

            await _emailService.EnviarCorreoRecuperacion(usuario.Email, subject, message);

            return Ok("Se ha enviado un enlace de recuperación a su correo electrónico.");
        }

        // Cambiar contraseña usando el token
        [HttpPost("cambiar")]
        public async Task<IActionResult> CambiarContrasena([FromForm] CambioContrasenaDto cambioContrasena)
        {
            var tokenRecuperacion = await _context.TokenRecuperacion
                .FirstOrDefaultAsync(t => t.Token == cambioContrasena.Token && !t.Usado && t.FechaExpiracion > DateTime.Now);

            if (tokenRecuperacion == null)
                return BadRequest("Token inválido o expirado");

            var usuario = await _context.Usuarios.FindAsync(tokenRecuperacion.UsuarioId);
            if (usuario == null)
                return NotFound("Usuario no encontrado");

            if (string.IsNullOrWhiteSpace(cambioContrasena.NuevaContrasena) || cambioContrasena.NuevaContrasena.Length < 6)
            {
                return BadRequest("La contraseña debe tener al menos 6 caracteres.");
            }

            usuario.Contrasena = cambioContrasena.NuevaContrasena;
            tokenRecuperacion.Usado = true;

            await _context.SaveChangesAsync();
            return Ok("Contraseña actualizada exitosamente");
        }
    }

    // DTO para cambio de contraseña
    public class CambioContrasenaDto
    {
        public string Token { get; set; }
        public string NuevaContrasena { get; set; }
    }
}
