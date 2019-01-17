using Microsoft.EntityFrameworkCore.Migrations;

namespace EfSamurai.Data.Migrations
{
    public partial class _10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Samurais_QuotesDbSet_QuoteId",
                table: "Samurais");

            migrationBuilder.DropIndex(
                name: "IX_Samurais_QuoteId",
                table: "Samurais");

            migrationBuilder.DropColumn(
                name: "QuoteId",
                table: "Samurais");

            migrationBuilder.RenameColumn(
                name: "QuouteType",
                table: "QuotesDbSet",
                newName: "QuoteType");

            migrationBuilder.AddColumn<int>(
                name: "SamuraiId",
                table: "QuotesDbSet",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_QuotesDbSet_SamuraiId",
                table: "QuotesDbSet",
                column: "SamuraiId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuotesDbSet_Samurais_SamuraiId",
                table: "QuotesDbSet",
                column: "SamuraiId",
                principalTable: "Samurais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuotesDbSet_Samurais_SamuraiId",
                table: "QuotesDbSet");

            migrationBuilder.DropIndex(
                name: "IX_QuotesDbSet_SamuraiId",
                table: "QuotesDbSet");

            migrationBuilder.DropColumn(
                name: "SamuraiId",
                table: "QuotesDbSet");

            migrationBuilder.RenameColumn(
                name: "QuoteType",
                table: "QuotesDbSet",
                newName: "QuouteType");

            migrationBuilder.AddColumn<int>(
                name: "QuoteId",
                table: "Samurais",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Samurais_QuoteId",
                table: "Samurais",
                column: "QuoteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Samurais_QuotesDbSet_QuoteId",
                table: "Samurais",
                column: "QuoteId",
                principalTable: "QuotesDbSet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
