using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Glamping_Addventure2.Migrations
{
    /// <inheritdoc />
    public partial class IsActive : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Usuarios");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Usuarios",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Usuarios");

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
