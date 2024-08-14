using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTour.Migrations
{
    /// <inheritdoc />
    public partial class changes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Passengers_Bookings_Booking_Id1",
                table: "Passengers");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Bookings_Booking_Id1",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Payments_Booking_Id1",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Passengers_Booking_Id1",
                table: "Passengers");

            migrationBuilder.DropColumn(
                name: "Booking_Id1",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "Booking_Id1",
                table: "Passengers");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_Booking_Id",
                table: "Payments",
                column: "Booking_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Passengers_Booking_Id",
                table: "Passengers",
                column: "Booking_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Passengers_Bookings_Booking_Id",
                table: "Passengers",
                column: "Booking_Id",
                principalTable: "Bookings",
                principalColumn: "Booking_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Bookings_Booking_Id",
                table: "Payments",
                column: "Booking_Id",
                principalTable: "Bookings",
                principalColumn: "Booking_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Passengers_Bookings_Booking_Id",
                table: "Passengers");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Bookings_Booking_Id",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Payments_Booking_Id",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Passengers_Booking_Id",
                table: "Passengers");

            migrationBuilder.AddColumn<int>(
                name: "Booking_Id1",
                table: "Payments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Booking_Id1",
                table: "Passengers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Payments_Booking_Id1",
                table: "Payments",
                column: "Booking_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_Passengers_Booking_Id1",
                table: "Passengers",
                column: "Booking_Id1");

            migrationBuilder.AddForeignKey(
                name: "FK_Passengers_Bookings_Booking_Id1",
                table: "Passengers",
                column: "Booking_Id1",
                principalTable: "Bookings",
                principalColumn: "Booking_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Bookings_Booking_Id1",
                table: "Payments",
                column: "Booking_Id1",
                principalTable: "Bookings",
                principalColumn: "Booking_Id");
        }
    }
}
