using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace indecor_web_site.Migrations
{
    public partial class CreateFromOurBlogTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FromOurBlogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(maxLength: 150, nullable: false),
                    TitlePost = table.Column<string>(maxLength: 100, nullable: false),
                    TitleHash = table.Column<string>(maxLength: 100, nullable: false),
                    TitleDate = table.Column<string>(maxLength: 100, nullable: false),
                    Image = table.Column<string>(maxLength: 180, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FromOurBlogs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FromOurBlogs");
        }
    }
}
