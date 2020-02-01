using Microsoft.EntityFrameworkCore.Migrations;

namespace DuoLingQCombiner.Migrations
{
    public partial class yes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WordStrings",
                table: "WordLists");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WordStrings",
                table: "WordLists",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
