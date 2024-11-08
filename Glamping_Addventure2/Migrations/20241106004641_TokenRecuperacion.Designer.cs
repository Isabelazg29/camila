﻿// <auto-generated />
using System;
using Glamping_Addventure2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Glamping_Addventure2.Migrations
{
    [DbContext(typeof(GlampingAddventureContext))]
    [Migration("20241106004641_TokenRecuperacion")]
    partial class TokenRecuperacion
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Glamping_Addventure2.Models.Abono", b =>
                {
                    b.Property<int>("Idabono")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDAbono");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Idabono"));

                    b.Property<string>("Estado")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<DateOnly?>("Fecha")
                        .HasColumnType("date");

                    b.Property<int?>("Idreserva")
                        .HasColumnType("int")
                        .HasColumnName("IDReserva");

                    b.Property<int?>("Iva")
                        .HasColumnType("int")
                        .HasColumnName("IVA");

                    b.Property<int?>("Subtotal")
                        .HasColumnType("int");

                    b.Property<int?>("Total")
                        .HasColumnType("int");

                    b.HasKey("Idabono")
                        .HasName("PK__Abono__8647F8A9B65C89B5");

                    b.HasIndex("Idreserva");

                    b.ToTable("Abono", (string)null);
                });

            modelBuilder.Entity("Glamping_Addventure2.Models.Cliente", b =>
                {
                    b.Property<int>("Idcliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDCliente");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Idcliente"));

                    b.Property<string>("Apellido")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Direccion")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Estado")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("Idrol")
                        .HasColumnType("int")
                        .HasColumnName("IDRol");

                    b.Property<string>("Nombre")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Telefono")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("TipoDocumento")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Idcliente")
                        .HasName("PK__Clientes__9B8553FC77E5836A");

                    b.HasIndex("Idrol");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Glamping_Addventure2.Models.DetalleReservaHabitacion", b =>
                {
                    b.Property<int>("IddetalleReservaHabitacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDDetalleReservaHabitacion");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IddetalleReservaHabitacion"));

                    b.Property<int?>("Cantidad")
                        .HasColumnType("int");

                    b.Property<string>("Estado")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("Idhabitacion")
                        .HasColumnType("int")
                        .HasColumnName("IDHabitacion");

                    b.Property<int?>("Idreserva")
                        .HasColumnType("int")
                        .HasColumnName("IDReserva");

                    b.Property<int?>("Precio")
                        .HasColumnType("int");

                    b.HasKey("IddetalleReservaHabitacion")
                        .HasName("PK__DetalleR__8CA3B406866AC630");

                    b.HasIndex("Idhabitacion");

                    b.HasIndex("Idreserva");

                    b.ToTable("DetalleReservaHabitacion", (string)null);
                });

            modelBuilder.Entity("Glamping_Addventure2.Models.DetalleReservaPaquete", b =>
                {
                    b.Property<int>("IddetalleReservaPaquetes")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDDetalleReservaPaquetes");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IddetalleReservaPaquetes"));

                    b.Property<int?>("Cantidad")
                        .HasColumnType("int");

                    b.Property<string>("Estado")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("Idpaquete")
                        .HasColumnType("int")
                        .HasColumnName("IDPaquete");

                    b.Property<int?>("Idreserva")
                        .HasColumnType("int")
                        .HasColumnName("IDReserva");

                    b.Property<int?>("Precio")
                        .HasColumnType("int");

                    b.HasKey("IddetalleReservaPaquetes")
                        .HasName("PK__DetalleR__64F9FDAEF183D840");

                    b.HasIndex("Idpaquete");

                    b.HasIndex("Idreserva");

                    b.ToTable("DetalleReservaPaquetes");
                });

            modelBuilder.Entity("Glamping_Addventure2.Models.DetalleReservaServicio", b =>
                {
                    b.Property<int>("IddetalleReservaServicio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDDetalleReservaServicio");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IddetalleReservaServicio"));

                    b.Property<int?>("Cantidad")
                        .HasColumnType("int");

                    b.Property<string>("Estado")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("Idreserva")
                        .HasColumnType("int")
                        .HasColumnName("IDReserva");

                    b.Property<int?>("Idservicio")
                        .HasColumnType("int")
                        .HasColumnName("IDServicio");

                    b.Property<int?>("Precio")
                        .HasColumnType("int");

                    b.HasKey("IddetalleReservaServicio")
                        .HasName("PK__DetalleR__B52B22F81FEA71BF");

                    b.HasIndex("Idreserva");

                    b.HasIndex("Idservicio");

                    b.ToTable("DetalleReservaServicio", (string)null);
                });

            modelBuilder.Entity("Glamping_Addventure2.Models.Empresa", b =>
                {
                    b.Property<int>("Idempresa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDEmpresa");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Idempresa"));

                    b.Property<string>("PronombrePrimero")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("Telefono")
                        .HasColumnType("int");

                    b.HasKey("Idempresa")
                        .HasName("PK__Empresa__ED09F0D5F1EE16D2");

                    b.ToTable("Empresa", (string)null);
                });

            modelBuilder.Entity("Glamping_Addventure2.Models.Habitacion", b =>
                {
                    b.Property<int>("Idhabitacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDHabitacion");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Idhabitacion"));

                    b.Property<int?>("CantidadPersonas")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("IdtipodeHabitacion")
                        .HasColumnType("int")
                        .HasColumnName("IDTipodeHabitacion");

                    b.Property<byte[]>("ImagenHabitacion")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("NombreHabitacion")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Piso")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<decimal?>("Precio")
                        .HasColumnType("decimal(18, 0)");

                    b.HasKey("Idhabitacion")
                        .HasName("PK__Habitaci__6B4757DAE0A23709");

                    b.HasIndex("IdtipodeHabitacion");

                    b.ToTable("Habitacion", (string)null);
                });

            modelBuilder.Entity("Glamping_Addventure2.Models.HabitacionInmueble", b =>
                {
                    b.Property<int>("IdhabitacionInmuebles")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDHabitacionInmuebles");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdhabitacionInmuebles"));

                    b.Property<int?>("Idhabitacion")
                        .HasColumnType("int")
                        .HasColumnName("IDHabitacion");

                    b.Property<int?>("Idinmueble")
                        .HasColumnType("int")
                        .HasColumnName("IDInmueble");

                    b.HasKey("IdhabitacionInmuebles")
                        .HasName("PK__Habitaci__8FBCBDB4862007C1");

                    b.HasIndex("Idhabitacion");

                    b.HasIndex("Idinmueble");

                    b.ToTable("HabitacionInmuebles");
                });

            modelBuilder.Entity("Glamping_Addventure2.Models.Inmueble", b =>
                {
                    b.Property<int>("Idinmueble")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDInmueble");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Idinmueble"));

                    b.Property<int?>("CantidadInmueble")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<byte[]>("ImagenInmueble")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("NombreInmueble")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<int?>("Precio")
                        .HasColumnType("int");

                    b.HasKey("Idinmueble")
                        .HasName("PK__Inmueble__8FFA1C88E82C900F");

                    b.ToTable("Inmuebles");
                });

            modelBuilder.Entity("Glamping_Addventure2.Models.MetodoPago", b =>
                {
                    b.Property<int>("IdmetodoPago")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDMetodoPago");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdmetodoPago"));

                    b.Property<string>("Estado")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Nombre")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("IdmetodoPago")
                        .HasName("PK__MetodoPa__8D99F33886309C22");

                    b.ToTable("MetodoPago", (string)null);
                });

            modelBuilder.Entity("Glamping_Addventure2.Models.Paquete", b =>
                {
                    b.Property<int>("Idpaquete")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDPaquete");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Idpaquete"));

                    b.Property<string>("Estado")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<DateOnly?>("FechaFin")
                        .HasColumnType("date");

                    b.Property<DateOnly?>("FechaInicio")
                        .HasColumnType("date");

                    b.Property<string>("NombrePaquete")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<int?>("Precio")
                        .HasColumnType("int");

                    b.HasKey("Idpaquete")
                        .HasName("PK__Paquetes__4C29513B2EA3D042");

                    b.ToTable("Paquetes");
                });

            modelBuilder.Entity("Glamping_Addventure2.Models.PaquetesHabitacion", b =>
                {
                    b.Property<int>("IdpaquetesHabitacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDPaquetesHabitacion");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdpaquetesHabitacion"));

                    b.Property<int?>("Idhabitacion")
                        .HasColumnType("int")
                        .HasColumnName("IDHabitacion");

                    b.Property<int?>("Idpaquete")
                        .HasColumnType("int")
                        .HasColumnName("IDPaquete");

                    b.HasKey("IdpaquetesHabitacion")
                        .HasName("PK__Paquetes__2EBD7781381D14C8");

                    b.HasIndex("Idhabitacion");

                    b.HasIndex("Idpaquete");

                    b.ToTable("PaquetesHabitacion", (string)null);
                });

            modelBuilder.Entity("Glamping_Addventure2.Models.PaquetesServicio", b =>
                {
                    b.Property<int>("IdpaquetesServicio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDPaquetesServicio");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdpaquetesServicio"));

                    b.Property<int?>("Idpaquete")
                        .HasColumnType("int")
                        .HasColumnName("IDPaquete");

                    b.Property<int?>("Idservicio")
                        .HasColumnType("int")
                        .HasColumnName("IDServicio");

                    b.HasKey("IdpaquetesServicio")
                        .HasName("PK__Paquetes__C5795B25439B50EF");

                    b.HasIndex("Idpaquete");

                    b.HasIndex("Idservicio");

                    b.ToTable("PaquetesServicio", (string)null);
                });

            modelBuilder.Entity("Glamping_Addventure2.Models.Permiso", b =>
                {
                    b.Property<int>("Idpermiso")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDPermiso");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Idpermiso"));

                    b.Property<string>("Descripcion")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("EstadoPermisos")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("NombrePermisos")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Idpermiso")
                        .HasName("PK__Permisos__F11D75F302FF0A29");

                    b.ToTable("Permisos");
                });

            modelBuilder.Entity("Glamping_Addventure2.Models.Reserva", b =>
                {
                    b.Property<int>("Idreserva")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDReserva");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Idreserva"));

                    b.Property<int?>("Estado")
                        .HasColumnType("int");

                    b.Property<DateOnly?>("FechaFin")
                        .HasColumnType("date");

                    b.Property<DateOnly?>("FechaInicio")
                        .HasColumnType("date");

                    b.Property<DateOnly?>("FechaReserva")
                        .HasColumnType("date");

                    b.Property<int?>("Idcliente")
                        .HasColumnType("int")
                        .HasColumnName("IDCliente");

                    b.Property<int?>("Idempresa")
                        .HasColumnType("int")
                        .HasColumnName("IDEmpresa");

                    b.Property<int?>("IdmetodoPago")
                        .HasColumnType("int")
                        .HasColumnName("IDMetodoPago");

                    b.Property<int?>("Idusuario")
                        .HasColumnType("int")
                        .HasColumnName("IDUsuario");

                    b.Property<int?>("Iva")
                        .HasColumnType("int")
                        .HasColumnName("IVA");

                    b.Property<int?>("SubTotal")
                        .HasColumnType("int");

                    b.Property<int?>("Total")
                        .HasColumnType("int");

                    b.HasKey("Idreserva")
                        .HasName("PK__Reserva__D9F2FA671CC2091A");

                    b.HasIndex("Idcliente");

                    b.HasIndex("Idempresa");

                    b.HasIndex("IdmetodoPago");

                    b.HasIndex("Idusuario");

                    b.ToTable("Reserva", (string)null);
                });

            modelBuilder.Entity("Glamping_Addventure2.Models.Role", b =>
                {
                    b.Property<int>("Idrol")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDRol");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Idrol"));

                    b.Property<string>("Estado")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Idrol")
                        .HasName("PK__Roles__A681ACB6CDE3C190");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Glamping_Addventure2.Models.RolesPermiso", b =>
                {
                    b.Property<int>("IdrolPermiso")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDRolPermiso");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdrolPermiso"));

                    b.Property<int?>("Idpermiso")
                        .HasColumnType("int")
                        .HasColumnName("IDPermiso");

                    b.Property<int?>("Idrol")
                        .HasColumnType("int")
                        .HasColumnName("IDRol");

                    b.HasKey("IdrolPermiso")
                        .HasName("PK__RolesPer__3F09FABFAC4CF063");

                    b.HasIndex("Idpermiso");

                    b.HasIndex("Idrol");

                    b.ToTable("RolesPermisos");
                });

            modelBuilder.Entity("Glamping_Addventure2.Models.Servicio", b =>
                {
                    b.Property<int>("Idservicio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDServicio");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Idservicio"));

                    b.Property<int?>("CantidadMaximaPersonas")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<TimeOnly?>("Duracion")
                        .HasColumnType("time");

                    b.Property<byte[]>("ImagenServicio")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("NombreServicio")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<decimal?>("Precio")
                        .HasColumnType("decimal(18, 0)");

                    b.HasKey("Idservicio")
                        .HasName("PK__Servicio__3CCE7416760CD8A0");

                    b.ToTable("Servicios");
                });

            modelBuilder.Entity("Glamping_Addventure2.Models.TipodeHabitacion", b =>
                {
                    b.Property<int>("IdtipodeHabitacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDTipodeHabitacion");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdtipodeHabitacion"));

                    b.Property<string>("Descripcion")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<byte[]>("ImagenTipodeHabitacion")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("NombreTipodeHabitacion")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<decimal?>("Precio")
                        .HasColumnType("decimal(18, 0)");

                    b.HasKey("IdtipodeHabitacion")
                        .HasName("PK__TipodeHa__9BD4086C72AEB476");

                    b.ToTable("TipodeHabitacion", (string)null);
                });

            modelBuilder.Entity("Glamping_Addventure2.Models.Usuario", b =>
                {
                    b.Property<int>("Idusuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDUsuario");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Idusuario"));

                    b.Property<string>("Apellido")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Contrasena")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Direccion")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("Idrol")
                        .HasColumnType("int")
                        .HasColumnName("IDRol");

                    b.Property<string>("NombreUsuario")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("NumeroDocumento")
                        .HasColumnType("int");

                    b.Property<string>("Pais")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("TipoDocumento")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Idusuario")
                        .HasName("PK__Usuarios__5231116905826D68");

                    b.HasIndex("Idrol");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Glamping_Addventure2.Models.Abono", b =>
                {
                    b.HasOne("Glamping_Addventure2.Models.Reserva", "IdreservaNavigation")
                        .WithMany("Abonos")
                        .HasForeignKey("Idreserva")
                        .HasConstraintName("FK_Abono_Reserva");

                    b.Navigation("IdreservaNavigation");
                });

            modelBuilder.Entity("Glamping_Addventure2.Models.Cliente", b =>
                {
                    b.HasOne("Glamping_Addventure2.Models.Role", "IdrolNavigation")
                        .WithMany("Clientes")
                        .HasForeignKey("Idrol")
                        .HasConstraintName("FK_Clientes_Roles");

                    b.Navigation("IdrolNavigation");
                });

            modelBuilder.Entity("Glamping_Addventure2.Models.DetalleReservaHabitacion", b =>
                {
                    b.HasOne("Glamping_Addventure2.Models.Habitacion", "IdhabitacionNavigation")
                        .WithMany("DetalleReservaHabitacions")
                        .HasForeignKey("Idhabitacion")
                        .HasConstraintName("FK_DetalleReservaHabitacion_Habitacion");

                    b.HasOne("Glamping_Addventure2.Models.Reserva", "IdreservaNavigation")
                        .WithMany("DetalleReservaHabitacions")
                        .HasForeignKey("Idreserva")
                        .HasConstraintName("FK_DetalleReservaHabitacion_Reserva");

                    b.Navigation("IdhabitacionNavigation");

                    b.Navigation("IdreservaNavigation");
                });

            modelBuilder.Entity("Glamping_Addventure2.Models.DetalleReservaPaquete", b =>
                {
                    b.HasOne("Glamping_Addventure2.Models.Paquete", "IdpaqueteNavigation")
                        .WithMany("DetalleReservaPaquetes")
                        .HasForeignKey("Idpaquete")
                        .HasConstraintName("FK_DetalleReservaPaquetes_Paquete");

                    b.HasOne("Glamping_Addventure2.Models.Reserva", "IdreservaNavigation")
                        .WithMany("DetalleReservaPaquetes")
                        .HasForeignKey("Idreserva")
                        .HasConstraintName("FK_DetalleReservaPaquetes_Reserva");

                    b.Navigation("IdpaqueteNavigation");

                    b.Navigation("IdreservaNavigation");
                });

            modelBuilder.Entity("Glamping_Addventure2.Models.DetalleReservaServicio", b =>
                {
                    b.HasOne("Glamping_Addventure2.Models.Reserva", "IdreservaNavigation")
                        .WithMany("DetalleReservaServicios")
                        .HasForeignKey("Idreserva")
                        .HasConstraintName("FK_DetalleReservaServicio_Reserva");

                    b.HasOne("Glamping_Addventure2.Models.Servicio", "IdservicioNavigation")
                        .WithMany("DetalleReservaServicios")
                        .HasForeignKey("Idservicio")
                        .HasConstraintName("FK_DetalleReservaServicio_Servicio");

                    b.Navigation("IdreservaNavigation");

                    b.Navigation("IdservicioNavigation");
                });

            modelBuilder.Entity("Glamping_Addventure2.Models.Habitacion", b =>
                {
                    b.HasOne("Glamping_Addventure2.Models.TipodeHabitacion", "IdtipodeHabitacionNavigation")
                        .WithMany("Habitacions")
                        .HasForeignKey("IdtipodeHabitacion")
                        .HasConstraintName("FK_Habitacion_TipodeHabitacion");

                    b.Navigation("IdtipodeHabitacionNavigation");
                });

            modelBuilder.Entity("Glamping_Addventure2.Models.HabitacionInmueble", b =>
                {
                    b.HasOne("Glamping_Addventure2.Models.Habitacion", "IdhabitacionNavigation")
                        .WithMany("HabitacionInmuebles")
                        .HasForeignKey("Idhabitacion")
                        .HasConstraintName("FK_HabitacionInmuebles_Habitacion");

                    b.HasOne("Glamping_Addventure2.Models.Inmueble", "IdinmuebleNavigation")
                        .WithMany("HabitacionInmuebles")
                        .HasForeignKey("Idinmueble")
                        .HasConstraintName("FK_HabitacionInmuebles_Inmuebles");

                    b.Navigation("IdhabitacionNavigation");

                    b.Navigation("IdinmuebleNavigation");
                });

            modelBuilder.Entity("Glamping_Addventure2.Models.PaquetesHabitacion", b =>
                {
                    b.HasOne("Glamping_Addventure2.Models.Habitacion", "IdhabitacionNavigation")
                        .WithMany("PaquetesHabitacions")
                        .HasForeignKey("Idhabitacion")
                        .HasConstraintName("FK_PaquetesHabitacion_Habitacion");

                    b.HasOne("Glamping_Addventure2.Models.Paquete", "IdpaqueteNavigation")
                        .WithMany("PaquetesHabitacions")
                        .HasForeignKey("Idpaquete")
                        .HasConstraintName("FK_PaquetesHabitacion_Paquetes");

                    b.Navigation("IdhabitacionNavigation");

                    b.Navigation("IdpaqueteNavigation");
                });

            modelBuilder.Entity("Glamping_Addventure2.Models.PaquetesServicio", b =>
                {
                    b.HasOne("Glamping_Addventure2.Models.Paquete", "IdpaqueteNavigation")
                        .WithMany("PaquetesServicios")
                        .HasForeignKey("Idpaquete")
                        .HasConstraintName("FK_PaquetesServicio_Paquetes");

                    b.HasOne("Glamping_Addventure2.Models.Servicio", "IdservicioNavigation")
                        .WithMany("PaquetesServicios")
                        .HasForeignKey("Idservicio")
                        .HasConstraintName("FK_PaquetesServicio_Servicio");

                    b.Navigation("IdpaqueteNavigation");

                    b.Navigation("IdservicioNavigation");
                });

            modelBuilder.Entity("Glamping_Addventure2.Models.Reserva", b =>
                {
                    b.HasOne("Glamping_Addventure2.Models.Cliente", "IdclienteNavigation")
                        .WithMany("Reservas")
                        .HasForeignKey("Idcliente")
                        .HasConstraintName("FK_Reserva_Cliente");

                    b.HasOne("Glamping_Addventure2.Models.Empresa", "IdempresaNavigation")
                        .WithMany("Reservas")
                        .HasForeignKey("Idempresa")
                        .HasConstraintName("FK_Reserva_Empresa");

                    b.HasOne("Glamping_Addventure2.Models.MetodoPago", "IdmetodoPagoNavigation")
                        .WithMany("Reservas")
                        .HasForeignKey("IdmetodoPago")
                        .HasConstraintName("FK_Reserva_MetodoPago");

                    b.HasOne("Glamping_Addventure2.Models.Usuario", "IdusuarioNavigation")
                        .WithMany("Reservas")
                        .HasForeignKey("Idusuario")
                        .HasConstraintName("FK_Reserva_Usuario");

                    b.Navigation("IdclienteNavigation");

                    b.Navigation("IdempresaNavigation");

                    b.Navigation("IdmetodoPagoNavigation");

                    b.Navigation("IdusuarioNavigation");
                });

            modelBuilder.Entity("Glamping_Addventure2.Models.RolesPermiso", b =>
                {
                    b.HasOne("Glamping_Addventure2.Models.Permiso", "IdpermisoNavigation")
                        .WithMany("RolesPermisos")
                        .HasForeignKey("Idpermiso")
                        .HasConstraintName("FK_RolesPermisos_Permisos");

                    b.HasOne("Glamping_Addventure2.Models.Role", "IdrolNavigation")
                        .WithMany("RolesPermisos")
                        .HasForeignKey("Idrol")
                        .HasConstraintName("FK_RolesPermisos_Roles");

                    b.Navigation("IdpermisoNavigation");

                    b.Navigation("IdrolNavigation");
                });

            modelBuilder.Entity("Glamping_Addventure2.Models.Usuario", b =>
                {
                    b.HasOne("Glamping_Addventure2.Models.Role", "IdrolNavigation")
                        .WithMany("Usuarios")
                        .HasForeignKey("Idrol")
                        .HasConstraintName("FK_Usuarios_Roles");

                    b.Navigation("IdrolNavigation");
                });

            modelBuilder.Entity("Glamping_Addventure2.Models.Cliente", b =>
                {
                    b.Navigation("Reservas");
                });

            modelBuilder.Entity("Glamping_Addventure2.Models.Empresa", b =>
                {
                    b.Navigation("Reservas");
                });

            modelBuilder.Entity("Glamping_Addventure2.Models.Habitacion", b =>
                {
                    b.Navigation("DetalleReservaHabitacions");

                    b.Navigation("HabitacionInmuebles");

                    b.Navigation("PaquetesHabitacions");
                });

            modelBuilder.Entity("Glamping_Addventure2.Models.Inmueble", b =>
                {
                    b.Navigation("HabitacionInmuebles");
                });

            modelBuilder.Entity("Glamping_Addventure2.Models.MetodoPago", b =>
                {
                    b.Navigation("Reservas");
                });

            modelBuilder.Entity("Glamping_Addventure2.Models.Paquete", b =>
                {
                    b.Navigation("DetalleReservaPaquetes");

                    b.Navigation("PaquetesHabitacions");

                    b.Navigation("PaquetesServicios");
                });

            modelBuilder.Entity("Glamping_Addventure2.Models.Permiso", b =>
                {
                    b.Navigation("RolesPermisos");
                });

            modelBuilder.Entity("Glamping_Addventure2.Models.Reserva", b =>
                {
                    b.Navigation("Abonos");

                    b.Navigation("DetalleReservaHabitacions");

                    b.Navigation("DetalleReservaPaquetes");

                    b.Navigation("DetalleReservaServicios");
                });

            modelBuilder.Entity("Glamping_Addventure2.Models.Role", b =>
                {
                    b.Navigation("Clientes");

                    b.Navigation("RolesPermisos");

                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("Glamping_Addventure2.Models.Servicio", b =>
                {
                    b.Navigation("DetalleReservaServicios");

                    b.Navigation("PaquetesServicios");
                });

            modelBuilder.Entity("Glamping_Addventure2.Models.TipodeHabitacion", b =>
                {
                    b.Navigation("Habitacions");
                });

            modelBuilder.Entity("Glamping_Addventure2.Models.Usuario", b =>
                {
                    b.Navigation("Reservas");
                });
#pragma warning restore 612, 618
        }
    }
}
