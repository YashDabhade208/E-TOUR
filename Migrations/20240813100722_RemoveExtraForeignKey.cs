using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTour.Migrations
{
    /// <inheritdoc />
    public partial class RemoveExtraForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubCategories_Categories_Category_Id1",
                table: "SubCategories");

            migrationBuilder.DropIndex(
                name: "IX_SubCategories_Category_Id1",
                table: "SubCategories");

            migrationBuilder.DropColumn(
                name: "Category_Id1",
                table: "SubCategories");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_Category_Id",
                table: "SubCategories",
                column: "Category_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategories_Categories_Category_Id",
                table: "SubCategories",
                column: "Category_Id",
                principalTable: "Categories",
                principalColumn: "Category_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubCategories_Categories_Category_Id",
                table: "SubCategories");

            migrationBuilder.DropIndex(
                name: "IX_SubCategories_Category_Id",
                table: "SubCategories");

            migrationBuilder.AddColumn<int>(
                name: "Category_Id1",
                table: "SubCategories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_Category_Id1",
                table: "SubCategories",
                column: "Category_Id1");

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategories_Categories_Category_Id1",
                table: "SubCategories",
                column: "Category_Id1",
                principalTable: "Categories",
                principalColumn: "Category_Id");
        }
    }
}
