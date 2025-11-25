using Microsoft.EntityFrameworkCore.Migrations;
using Wasla_Backend.Models;

#nullable disable

namespace Wasla_Backend.Data.Migrations
{
    public partial class AddUniqueIndexToBooking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                WITH cte AS (
                    SELECT 
                        Id,
                        ROW_NUMBER() OVER (PARTITION BY ServiceId ORDER BY Id) AS rn
                    FROM Booking
                )
                DELETE FROM cte WHERE rn > 1;
            ");

            migrationBuilder.DropIndex(
                name: "IX_Booking_ServiceId",
                table: "Booking");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_ServiceId",
            table: "Booking",
                column: "ServiceId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Booking_ServiceId",
                table: "Booking");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_ServiceId",
            table: "Booking",
                column: "ServiceId");
        }
    }
}
