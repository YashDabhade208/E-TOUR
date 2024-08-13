using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTour.Migrations
{
    /// <inheritdoc />
    public partial class eTour : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(name: "Category_Id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(name: "Category_Name", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    SubcategoryId = table.Column<int>(name: "Subcategory_Id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubcategoryName = table.Column<string>(name: "Subcategory_Name", type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(name: "Category_Id", type: "int", nullable: false),
                    CategoryId1 = table.Column<int>(name: "Category_Id1", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.SubcategoryId);
                    table.ForeignKey(
                        name: "FK_SubCategories_Categories_Category_Id1",
                        column: x => x.CategoryId1,
                        principalTable: "Categories",
                        principalColumn: "Category_Id");
                });

            migrationBuilder.CreateTable(
                name: "Tour",
                columns: table => new
                {
                    TourId = table.Column<int>(name: "Tour_Id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TourName = table.Column<string>(name: "Tour_Name", type: "nvarchar(max)", nullable: true),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    SubcategoryId = table.Column<int>(name: "Subcategory_Id", type: "int", nullable: false),
                    SubcategoryId1 = table.Column<int>(name: "Subcategory_Id1", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tour", x => x.TourId);
                    table.ForeignKey(
                        name: "FK_Tour_SubCategories_Subcategory_Id1",
                        column: x => x.SubcategoryId1,
                        principalTable: "SubCategories",
                        principalColumn: "Subcategory_Id");
                });

            migrationBuilder.CreateTable(
                name: "Iterneries",
                columns: table => new
                {
                    IterneryId = table.Column<int>(name: "Iternery_Id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TourId = table.Column<int>(name: "Tour_Id", type: "int", nullable: false),
                    ToursTourId = table.Column<int>(name: "ToursTour_Id", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iterneries", x => x.IterneryId);
                    table.ForeignKey(
                        name: "FK_Iterneries_Tour_ToursTour_Id",
                        column: x => x.ToursTourId,
                        principalTable: "Tour",
                        principalColumn: "Tour_Id");
                });

            migrationBuilder.CreateTable(
                name: "TourDates",
                columns: table => new
                {
                    TourdateId = table.Column<int>(name: "Tourdate_Id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Validfrom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Validto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TourId = table.Column<int>(name: "Tour_Id", type: "int", nullable: false),
                    ToursTourId = table.Column<int>(name: "ToursTour_Id", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourDates", x => x.TourdateId);
                    table.ForeignKey(
                        name: "FK_TourDates_Tour_ToursTour_Id",
                        column: x => x.ToursTourId,
                        principalTable: "Tour",
                        principalColumn: "Tour_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Iterneries_ToursTour_Id",
                table: "Iterneries",
                column: "ToursTour_Id");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_Category_Id1",
                table: "SubCategories",
                column: "Category_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_Tour_Subcategory_Id1",
                table: "Tour",
                column: "Subcategory_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_TourDates_ToursTour_Id",
                table: "TourDates",
                column: "ToursTour_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Iterneries");

            migrationBuilder.DropTable(
                name: "TourDates");

            migrationBuilder.DropTable(
                name: "Tour");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
