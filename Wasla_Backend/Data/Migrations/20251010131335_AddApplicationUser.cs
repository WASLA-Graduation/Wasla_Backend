using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Wasla_Backend.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddApplicationUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "IsVerified",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "LastLogin",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "ProfilePhoto",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Resident");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Resident");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Resident");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Resident");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Resident");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Resident");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Resident");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Resident");

            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Resident");

            migrationBuilder.DropColumn(
                name: "IsVerified",
                table: "Resident");

            migrationBuilder.DropColumn(
                name: "LastLogin",
                table: "Resident");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Resident");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Resident");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Resident");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Resident");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Resident");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Resident");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Resident");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Resident");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Resident");

            migrationBuilder.DropColumn(
                name: "ProfilePhoto",
                table: "Resident");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "Resident");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Resident");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "Resident");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Resident");

            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Gym");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Gym");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Gym");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Gym");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Gym");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Gym");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Gym");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Gym");

            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Gym");

            migrationBuilder.DropColumn(
                name: "IsVerified",
                table: "Gym");

            migrationBuilder.DropColumn(
                name: "LastLogin",
                table: "Gym");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Gym");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Gym");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Gym");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Gym");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Gym");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Gym");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Gym");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Gym");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Gym");

            migrationBuilder.DropColumn(
                name: "ProfilePhoto",
                table: "Gym");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "Gym");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Gym");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "Gym");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Gym");

            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "IsVerified",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "LastLogin",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "ProfilePhoto",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "IsVerified",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "LastLogin",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "ProfilePhoto",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Doctor");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "AspNetUserClaims",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfilePhoto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    IsVerified = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastLogin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctor_AspNetUsers_Id",
                table: "Doctor",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Driver_AspNetUsers_Id",
                table: "Driver",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Gym_AspNetUsers_Id",
                table: "Gym",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Resident_AspNetUsers_Id",
                table: "Resident",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Restaurant_AspNetUsers_Id",
                table: "Restaurant",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctor_AspNetUsers_Id",
                table: "Doctor");

            migrationBuilder.DropForeignKey(
                name: "FK_Driver_AspNetUsers_Id",
                table: "Driver");

            migrationBuilder.DropForeignKey(
                name: "FK_Gym_AspNetUsers_Id",
                table: "Gym");

            migrationBuilder.DropForeignKey(
                name: "FK_Resident_AspNetUsers_Id",
                table: "Resident");

            migrationBuilder.DropForeignKey(
                name: "FK_Restaurant_AspNetUsers_Id",
                table: "Restaurant");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Restaurant",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Restaurant",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Restaurant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Restaurant",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Restaurant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Restaurant",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Restaurant",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Restaurant",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Restaurant",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsVerified",
                table: "Restaurant",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastLogin",
                table: "Restaurant",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Restaurant",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Restaurant",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Restaurant",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Restaurant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Restaurant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Restaurant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Restaurant",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Restaurant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Restaurant",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ProfilePhoto",
                table: "Restaurant",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Restaurant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Restaurant",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Restaurant",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Restaurant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Resident",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Resident",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Resident",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Resident",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Resident",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Resident",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Resident",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Resident",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Resident",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsVerified",
                table: "Resident",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastLogin",
                table: "Resident",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Resident",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Resident",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Resident",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Resident",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Resident",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Resident",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Resident",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Resident",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Resident",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ProfilePhoto",
                table: "Resident",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Resident",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Resident",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Resident",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Resident",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Gym",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Gym",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Gym",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Gym",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Gym",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Gym",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Gym",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Gym",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Gym",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsVerified",
                table: "Gym",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastLogin",
                table: "Gym",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Gym",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Gym",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Gym",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Gym",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Gym",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Gym",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Gym",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Gym",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Gym",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ProfilePhoto",
                table: "Gym",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Gym",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Gym",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Gym",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Gym",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Driver",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Driver",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Driver",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Driver",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Driver",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Driver",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Driver",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Driver",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Driver",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsVerified",
                table: "Driver",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastLogin",
                table: "Driver",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Driver",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Driver",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Driver",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Driver",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Driver",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Driver",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Driver",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Driver",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Driver",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ProfilePhoto",
                table: "Driver",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Driver",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Driver",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Driver",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Driver",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Doctor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Doctor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Doctor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Doctor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Doctor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Doctor",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Doctor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Doctor",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Doctor",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsVerified",
                table: "Doctor",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastLogin",
                table: "Doctor",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Doctor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Doctor",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Doctor",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Doctor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Doctor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Doctor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Doctor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Doctor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Doctor",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ProfilePhoto",
                table: "Doctor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Doctor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Doctor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Doctor",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Doctor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "AspNetUserLogins",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "AspNetUserClaims",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
