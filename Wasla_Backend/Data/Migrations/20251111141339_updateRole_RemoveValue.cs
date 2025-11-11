using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Wasla_Backend.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateRole_RemoveValue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Value",
                table: "AspNetRoles");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Value",
                table: "AspNetRoles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
