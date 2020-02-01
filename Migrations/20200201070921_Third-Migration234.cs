using Microsoft.EntityFrameworkCore.Migrations;

namespace DuoLingQCombiner.Migrations
{
    public partial class ThirdMigration234 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WordStrings",
                table: "WordLists",
                nullable: true,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WordStrings",
                table: "WordLists");
        }
    }
}
