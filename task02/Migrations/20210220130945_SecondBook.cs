using Microsoft.EntityFrameworkCore.Migrations;

namespace task02.Migrations
{
    public partial class SecondBook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookID", "AuthorID", "BookName", "BookYear" },
                values: new object[] { 2, 1, "The Snake", 2009 });

            migrationBuilder.InsertData(
                table: "Generes",
                columns: new[] { "GenreID", "GenreName" },
                values: new object[] { 2, "war film" });

            migrationBuilder.InsertData(
                table: "BookGenreMaps",
                columns: new[] { "BookGenreMapID", "Book", "BookID", "Genre", "GenreID" },
                values: new object[] { 2, "The Snake", 2, "fantasy", 1 });

            migrationBuilder.InsertData(
                table: "BookGenreMaps",
                columns: new[] { "BookGenreMapID", "Book", "BookID", "Genre", "GenreID" },
                values: new object[] { 3, "The Snake", 2, "war film", 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookGenreMaps",
                keyColumn: "BookGenreMapID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BookGenreMaps",
                keyColumn: "BookGenreMapID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Generes",
                keyColumn: "GenreID",
                keyValue: 2);
        }
    }
}
