using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Glamping_Addventure2.Services
{
    public class EmailService : IEmailService
    {
        public async Task EnviarCorreoRecuperacion(string email, string subject, string message)
        {
            var smtpClient = new SmtpClient("smtp.tuservidor.com") // Cambia por el servidor SMTP que uses
            {
                Port = 587,
                Credentials = new NetworkCredential("tu-correo@dominio.com", "tu-contraseña"),
                EnableSsl = true,
            };

            var mailMessage = new MailMessage
            {
                From = new MailAddress("tu-correo@dominio.com"),
                Subject = subject,
                Body = message,
                IsBodyHtml = true,
            };
            mailMessage.To.Add(email);

            await smtpClient.SendMailAsync(mailMessage);
        }
    }
}
