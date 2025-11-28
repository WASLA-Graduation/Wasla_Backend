using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Wasla_Backend.data
{
    /// <inheritdoc />
    public partial class UpdateDates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_TimeSlot_timeSlotId",
                table: "Booking");

            migrationBuilder.DropTable(
                name: "TimeSlot");

            migrationBuilder.DropTable(
                name: "ServiceDate");

            migrationBuilder.DropIndex(
                name: "IX_Booking_timeSlotId",
                table: "Booking");

            migrationBuilder.AddColumn<string>(
                name: "end",
                table: "ServiceDay",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "isBooking",
                table: "ServiceDay",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "start",
                table: "ServiceDay",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "serviceDayId",
                table: "Booking",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Booking_serviceDayId",
                table: "Booking",
                column: "serviceDayId");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_ServiceDay_serviceDayId",
                table: "Booking",
                column: "serviceDayId",
                principalTable: "ServiceDay",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_ServiceDay_serviceDayId",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_serviceDayId",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "end",
                table: "ServiceDay");

            migrationBuilder.DropColumn(
                name: "isBooking",
                table: "ServiceDay");

            migrationBuilder.DropColumn(
                name: "start",
                table: "ServiceDay");

            migrationBuilder.DropColumn(
                name: "serviceDayId",
                table: "Booking");

            migrationBuilder.CreateTable(
                name: "ServiceDate",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    serviceId = table.Column<int>(type: "int", nullable: false),
                    date = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceDate", x => x.id);
                    table.ForeignKey(
                        name: "FK_ServiceDate_Service_serviceId",
                        column: x => x.serviceId,
                        principalTable: "Service",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TimeSlot",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    serviceDateId = table.Column<int>(type: "int", nullable: false),
                    serviceDayId = table.Column<int>(type: "int", nullable: false),
                    end = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isBooking = table.Column<bool>(type: "bit", nullable: false),
                    start = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeSlot", x => x.id);
                    table.ForeignKey(
                        name: "FK_TimeSlot_ServiceDate_serviceDateId",
                        column: x => x.serviceDateId,
                        principalTable: "ServiceDate",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_TimeSlot_ServiceDay_serviceDayId",
                        column: x => x.serviceDayId,
                        principalTable: "ServiceDay",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Booking_timeSlotId",
                table: "Booking",
                column: "timeSlotId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ServiceDate_serviceId",
                table: "ServiceDate",
                column: "serviceId");

            migrationBuilder.CreateIndex(
                name: "IX_TimeSlot_serviceDateId",
                table: "TimeSlot",
                column: "serviceDateId");

            migrationBuilder.CreateIndex(
                name: "IX_TimeSlot_serviceDayId",
                table: "TimeSlot",
                column: "serviceDayId");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_TimeSlot_timeSlotId",
                table: "Booking",
                column: "timeSlotId",
                principalTable: "TimeSlot",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
