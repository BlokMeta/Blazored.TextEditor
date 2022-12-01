using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorServerSide.Migrations
{
    public partial class EmailDbContextMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Templates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TemplateContext = table.Column<string>(nullable: true),
                    TemplateName = table.Column<string>(nullable: true),
                    TemplateStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Templates", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Templates");
        }
    }
}
