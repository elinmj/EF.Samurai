using Microsoft.EntityFrameworkCore.Migrations;

namespace EfSamurai.Data.Migrations
{
    public partial class _8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
