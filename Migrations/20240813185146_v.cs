using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTour.Migrations
{
    /// <inheritdoc />
    public partial class v : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Category_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category_Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Category_Id);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    Subcategory_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Subcategory_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.Subcategory_Id);
                    table.ForeignKey(
                        name: "FK_SubCategories_Categories_Category_Id",
                        column: x => x.Category_Id,
                        principalTable: "Categories",
                        principalColumn: "Category_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tour",
                columns: table => new
                {
                    Tour_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tour_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    SubCategory = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tour", x => x.Tour_Id);
                    table.ForeignKey(
                        name: "FK_Tour_SubCategories_SubCategory",
                        column: x => x.SubCategory,
                        principalTable: "SubCategories",
                        principalColumn: "Subcategory_Id");
                });

            migrationBuilder.CreateTable(
                name: "Costs",
                columns: table => new
                {
                    Cost_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tour_Cost = table.Column<int>(type: "int", nullable: false),
                    Childwithbed = table.Column<int>(type: "int", nullable: false),
                    Childwithoutbed = table.Column<int>(type: "int", nullable: false),
                    Tour_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Costs", x => x.Cost_id);
                    table.ForeignKey(
                        name: "FK_Costs_Tour_Tour_Id",
                        column: x => x.Tour_Id,
                        principalTable: "Tour",
                        principalColumn: "Tour_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Iterneries",
                columns: table => new
                {
                    Iternery_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tour_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iterneries", x => x.Iternery_Id);
                    table.ForeignKey(
                        name: "FK_Iterneries_Tour_Tour_Id",
                        column: x => x.Tour_Id,
                        principalTable: "Tour",
                        principalColumn: "Tour_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TourDates",
                columns: table => new
                {
                    Tourdate_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Validfrom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Validto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tour_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourDates", x => x.Tourdate_Id);
                    table.ForeignKey(
                        name: "FK_TourDates_Tour_Tour_Id",
                        column: x => x.Tour_Id,
                        principalTable: "Tour",
                        principalColumn: "Tour_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Costs_Tour_Id",
                table: "Costs",
                column: "Tour_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Iterneries_Tour_Id",
                table: "Iterneries",
                column: "Tour_Id");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_Category_Id",
                table: "SubCategories",
                column: "Category_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tour_SubCategory",
                table: "Tour",
                column: "SubCategory");

            migrationBuilder.CreateIndex(
                name: "IX_TourDates_Tour_Id",
                table: "TourDates",
                column: "Tour_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Costs");

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
