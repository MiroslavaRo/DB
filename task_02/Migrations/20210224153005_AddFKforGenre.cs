using Microsoft.EntityFrameworkCore.Migrations;

namespace task_02.Migrations
{
    public partial class AddFKforGenre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Books_GenreID",
                table: "Books",
                column: "GenreID");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Geners_GenreID",
                table: "Books",
                column: "GenreID",
                principalTable: "Geners",
                principalColumn: "GenreID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Geners_GenreID",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_GenreID",
                table: "Books");
        }
    }
}
