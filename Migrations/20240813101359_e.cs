using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTour.Migrations
{
    /// <inheritdoc />
    public partial class e : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tour_SubCategories_Subcategory_Id1",
                table: "Tour");

            migrationBuilder.DropForeignKey(
                name: "FK_TourDates_Tour_ToursTour_Id",
                table: "TourDates");

            migrationBuilder.DropIndex(
                name: "IX_TourDates_ToursTour_Id",
                table: "TourDates");

            migrationBuilder.DropColumn(
                name: "ToursTour_Id",
                table: "TourDates");

            migrationBuilder.DropColumn(
                name: "Subcategory_Id",
                table: "Tour");

            migrationBuilder.RenameColumn(
                name: "Subcategory_Id1",
                table: "Tour",
                newName: "SubCategory");

            migrationBuilder.RenameIndex(
                name: "IX_Tour_Subcategory_Id1",
                table: "Tour",
                newName: "IX_Tour_SubCategory");

            migrationBuilder.CreateIndex(
                name: "IX_TourDates_Tour_Id",
                table: "TourDates",
                column: "Tour_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tour_SubCategories_SubCategory",
                table: "Tour",
                column: "SubCategory",
                principalTable: "SubCategories",
                principalColumn: "Subcategory_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TourDates_Tour_Tour_Id",
                table: "TourDates",
                column: "Tour_Id",
                principalTable: "Tour",
                principalColumn: "Tour_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tour_SubCategories_SubCategory",
                table: "Tour");

            migrationBuilder.DropForeignKey(
                name: "FK_TourDates_Tour_Tour_Id",
                table: "TourDates");

            migrationBuilder.DropIndex(
                name: "IX_TourDates_Tour_Id",
                table: "TourDates");

            migrationBuilder.RenameColumn(
                name: "SubCategory",
                table: "Tour",
                newName: "Subcategory_Id1");

            migrationBuilder.RenameIndex(
                name: "IX_Tour_SubCategory",
                table: "Tour",
                newName: "IX_Tour_Subcategory_Id1");

            migrationBuilder.AddColumn<int>(
                name: "ToursTour_Id",
                table: "TourDates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Subcategory_Id",
                table: "Tour",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TourDates_ToursTour_Id",
                table: "TourDates",
                column: "ToursTour_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tour_SubCategories_Subcategory_Id1",
                table: "Tour",
                column: "Subcategory_Id1",
                principalTable: "SubCategories",
                principalColumn: "Subcategory_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TourDates_Tour_ToursTour_Id",
                table: "TourDates",
                column: "ToursTour_Id",
                principalTable: "Tour",
                principalColumn: "Tour_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
