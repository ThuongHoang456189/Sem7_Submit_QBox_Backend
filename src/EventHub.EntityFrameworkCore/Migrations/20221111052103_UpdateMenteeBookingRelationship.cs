using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventHub.Migrations
{
    public partial class UpdateMenteeBookingRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Mentee_MenteeId",
                table: "Booking");

            migrationBuilder.AddColumn<Guid>(
                name: "MenteeId1",
                table: "Booking",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Booking_MenteeId1",
                table: "Booking",
                column: "MenteeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Mentee_MenteeId",
                table: "Booking",
                column: "MenteeId",
                principalTable: "Mentee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Mentee_MenteeId1",
                table: "Booking",
                column: "MenteeId1",
                principalTable: "Mentee",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Mentee_MenteeId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Mentee_MenteeId1",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_MenteeId1",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "MenteeId1",
                table: "Booking");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Mentee_MenteeId",
                table: "Booking",
                column: "MenteeId",
                principalTable: "Mentee",
                principalColumn: "Id");
        }
    }
}
