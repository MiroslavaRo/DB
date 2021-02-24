using Microsoft.EntityFrameworkCore.Migrations;

namespace task02.Migrations
{
    public partial class ThirdBook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BookGenreMaps",
                columns: new[] { "BookGenreMapID", "Book", "BookID", "Genre", "GenreID" },
                values: new object[] { 5, "Harry Potter", 2, "drama", 2 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookID", "AuthorID", "BookName", "BookYear" },
                values: new object[] { 3, 2, "Harry Potter", 1997 });

            migrationBuilder.InsertData(
                table: "Generes",
                columns: new[] { "GenreID", "GenreName" },
                values: new object[] { 3, "drama" });

            migrationBuilder.InsertData(
                table: "BookGenreMaps",
                columns: new[] { "BookGenreMapID", "Book", "BookID", "Genre", "GenreID" },
                values: new object[] { 4, "Harry Potter", 3, "fantasy", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookGenreMaps",
                keyColumn: "BookGenreMapID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BookGenreMaps",
                keyColumn: "BookGenreMapID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Generes",
                keyColumn: "GenreID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 3);
        }
    }
}
