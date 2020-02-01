using Microsoft.EntityFrameworkCore.Migrations;

namespace DuoLingQCombiner.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Word_WordLists_WordListId",
                table: "Word");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Word",
                table: "Word");

            migrationBuilder.RenameTable(
                name: "Word",
                newName: "Words");

            migrationBuilder.RenameIndex(
                name: "IX_Word_WordListId",
                table: "Words",
                newName: "IX_Words_WordListId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Words",
                table: "Words",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Words_WordLists_WordListId",
                table: "Words",
                column: "WordListId",
                principalTable: "WordLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Words_WordLists_WordListId",
                table: "Words");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Words",
                table: "Words");

            migrationBuilder.RenameTable(
                name: "Words",
                newName: "Word");

            migrationBuilder.RenameIndex(
                name: "IX_Words_WordListId",
                table: "Word",
                newName: "IX_Word_WordListId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Word",
                table: "Word",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Word_WordLists_WordListId",
                table: "Word",
                column: "WordListId",
                principalTable: "WordLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
