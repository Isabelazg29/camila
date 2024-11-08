using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Glamping_Addventure2.Migrations
{
    /// <inheritdoc />
    public partial class CiudadyPais : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cuidad",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pais",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cuidad",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Pais",
                table: "Usuarios");
        }
    }
}
