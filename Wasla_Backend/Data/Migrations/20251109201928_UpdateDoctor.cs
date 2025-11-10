using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Wasla_Backend.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDoctor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Specialization",
                table: "Doctor",
                newName: "UniversityName");

            migrationBuilder.AddColumn<string>(
                name: "CV",
                table: "Restaurant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CV",
                table: "Gym",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CV",
                table: "Driver",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CV",
                table: "Doctor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "GraduationYear",
                table: "Doctor",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "SpecializationId",
                table: "Doctor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "DoctorSpecializations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Specialization_English = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Specialization_Arabic = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorSpecializations", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_SpecializationId",
                table: "Doctor",
                column: "SpecializationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctor_DoctorSpecializations_SpecializationId",
                table: "Doctor",
                column: "SpecializationId",
                principalTable: "DoctorSpecializations",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctor_DoctorSpecializations_SpecializationId",
                table: "Doctor");

            migrationBuilder.DropTable(
                name: "DoctorSpecializations");

            migrationBuilder.DropIndex(
                name: "IX_Doctor_SpecializationId",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "CV",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "CV",
                table: "Gym");

            migrationBuilder.DropColumn(
                name: "CV",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "CV",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "GraduationYear",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "SpecializationId",
                table: "Doctor");

            migrationBuilder.RenameColumn(
                name: "UniversityName",
                table: "Doctor",
                newName: "Specialization");
        }
    }
}
