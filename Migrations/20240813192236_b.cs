using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTour.Migrations
{
    /// <inheritdoc />
    public partial class b : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tour_SubCategories_SubCategory",
                table: "Tour");

            migrationBuilder.DropIndex(
                name: "IX_Tour_SubCategory",
                table: "Tour");

            migrationBuilder.DropColumn(
                name: "SubCategory",
                table: "Tour");

            migrationBuilder.AddColumn<int>(
                name: "SubCategory_Id",
                table: "Tour",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tour_SubCategory_Id",
                table: "Tour",
                column: "SubCategory_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tour_SubCategories_SubCategory_Id",
                table: "Tour",
                column: "SubCategory_Id",
                principalTable: "SubCategories",
                principalColumn: "Subcategory_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tour_SubCategories_SubCategory_Id",
                table: "Tour");

            migrationBuilder.DropIndex(
                name: "IX_Tour_SubCategory_Id",
                table: "Tour");

            migrationBuilder.DropColumn(
                name: "SubCategory_Id",
                table: "Tour");

            migrationBuilder.AddColumn<int>(
                name: "SubCategory",
                table: "Tour",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tour_SubCategory",
                table: "Tour",
                column: "SubCategory");

            migrationBuilder.AddForeignKey(
                name: "FK_Tour_SubCategories_SubCategory",
                table: "Tour",
                column: "SubCategory",
                principalTable: "SubCategories",
                principalColumn: "Subcategory_Id");
        }
    }
}
