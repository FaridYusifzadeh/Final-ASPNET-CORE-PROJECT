using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace indecor_web_site.Migrations
{
    public partial class CreateProductAndCategorieTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product_Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Active = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Count = table.Column<int>(maxLength: 10, nullable: false),
                    Percent = table.Column<string>(nullable: true),
                    Price = table.Column<double>(maxLength: 10, nullable: false),
                    PriceSale = table.Column<double>(nullable: false),
                    Image = table.Column<string>(maxLength: 100, nullable: false),
                    Active = table.Column<string>(nullable: true),
                    Description = table.Column<string>(maxLength: 300, nullable: false),
                    Datetime = table.Column<string>(nullable: true),
                    NEW_ARRIVALS = table.Column<bool>(nullable: false),
                    BEST_SELLER = table.Column<int>(nullable: false),
                    MOST_VIEW = table.Column<int>(nullable: false),
                    Product_CategorieId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Product_Categories_Product_CategorieId",
                        column: x => x.Product_CategorieId,
                        principalTable: "Product_Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_Product_CategorieId",
                table: "Products",
                column: "Product_CategorieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Product_Categories");
        }
    }
}
