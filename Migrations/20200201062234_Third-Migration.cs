using Microsoft.EntityFrameworkCore.Migrations;

namespace DuoLingQCombiner.Migrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Words_WordLists_WordListId",
                table: "Words");

            migrationBuilder.AlterColumn<int>(
                name: "WordListId",
                table: "Words",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Words_WordLists_WordListId",
                table: "Words",
                column: "WordListId",
                principalTable: "WordLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Words_WordLists_WordListId",
                table: "Words");

            migrationBuilder.AlterColumn<int>(
                name: "WordListId",
                table: "Words",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Words_WordLists_WordListId",
                table: "Words",
                column: "WordListId",
                principalTable: "WordLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
