using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Glamping_Addventure2.Migrations
{
    /// <inheritdoc />
    public partial class TokenRecuperacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Usuarios");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Usuarios",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
