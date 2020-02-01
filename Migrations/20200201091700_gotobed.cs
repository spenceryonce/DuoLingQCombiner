using Microsoft.EntityFrameworkCore.Migrations;

namespace DuoLingQCombiner.Migrations
{
    public partial class gotobed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DuolingoUsers",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    username = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    rupees = table.Column<int>(nullable: false),
                    created = table.Column<string>(nullable: true),
                    learning_language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DuolingoUsers", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DuolingoUsers");
        }
    }
}
