using Microsoft.EntityFrameworkCore.Migrations;

namespace task02.Migrations
{
    public partial class FirstGenre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Generes",
                columns: new[] { "GenreID", "GenreName" },
                values: new object[] { 1, "fantasy" });

            migrationBuilder.InsertData(
                table: "BookGenreMaps",
                columns: new[] { "BookGenreMapID", "Book", "BookID", "Genre", "GenreID" },
                values: new object[] { 1, null, 1, null, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookGenreMaps",
                keyColumn: "BookGenreMapID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Generes",
                keyColumn: "GenreID",
                keyValue: 1);
        }
    }
}
