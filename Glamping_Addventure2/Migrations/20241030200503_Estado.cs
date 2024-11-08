using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Glamping_Addventure2.Migrations
{
    /// <inheritdoc />
    public partial class Estado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cuidad",
                table: "Usuarios");

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Usuarios");

            migrationBuilder.AddColumn<string>(
                name: "Cuidad",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
