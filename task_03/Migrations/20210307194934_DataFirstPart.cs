using Microsoft.EntityFrameworkCore.Migrations;

namespace task_03.Migrations
{
    public partial class DataFirstPart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorID", "AuthorName" },
                values: new object[,]
                {
                    { 1, "A. Sapkowski" },
                    { 2, "H.P. Lovecraft" },
                    { 3, "J.K. Rowling" },
                    { 4, "O. Wilde" },
                    { 5, "S. King" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreID", "GenreName" },
                values: new object[,]
                {
                    { 1, "Philosophical fiction" },
                    { 2, "Fantasy" },
                    { 3, "Horror" },
                    { 4, "Historical fantasy" },
                    { 5, "Dark Fantasy" },
                    { 6, "Southern Gothic" },
                    { 7, "Magic Realism" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookID", "AuthorID", "BookName", "BookYear" },
                values: new object[,]
                {
                    { 1, 1, "Blood of Elves", 1994 },
                    { 2, 1, "The Tower of Fools", 2002 },
                    { 3, 1, "Sword of Destiny", 1992 },
                    { 4, 2, "The Call of Cthulhu", 1928 },
                    { 5, 2, "At the Mountains of Madness", 1931 },
                    { 6, 3, "Harry Potter and Philosopher's Stone", 1997 },
                    { 7, 3, "Harry Potter and Chamber of Secrets", 1998 },
                    { 8, 3, "Harry Potter and Prisoner of Azkaban", 1999 },
                    { 9, 3, "Harry Potter and Goblet of Fire", 2000 },
                    { 10, 3, "Harry Potter and Order of the Phoenix", 2003 },
                    { 11, 3, "Harry Potter and Half-Blood Prince", 2005 },
                    { 12, 3, "Harry Potter and Deathly Hallows", 2007 },
                    { 16, 4, "The Picture of Dorian Gray", 1890 },
                    { 13, 5, "The Eyes of the Dragon", 1984 },
                    { 14, 5, "Insomnia", 1994 },
                    { 15, 5, "The Green Mile", 1996 }
                });

            migrationBuilder.InsertData(
                table: "BookGenreMaps",
                columns: new[] { "BookGenreMapID", "BookID", "GenreID" },
                values: new object[,]
                {
                    { 2, 1, 2 },
                    { 17, 15, 5 },
                    { 15, 14, 3 },
                    { 12, 14, 2 },
                    { 11, 13, 2 },
                    { 1, 16, 1 },
                    { 10, 12, 2 },
                    { 9, 11, 2 },
                    { 18, 15, 6 },
                    { 8, 10, 2 },
                    { 6, 8, 2 },
                    { 5, 7, 2 },
                    { 4, 6, 2 },
                    { 14, 5, 3 },
                    { 13, 4, 3 },
                    { 3, 3, 2 },
                    { 16, 2, 4 },
                    { 7, 9, 2 },
                    { 19, 15, 7 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookGenreMaps",
                keyColumn: "BookGenreMapID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BookGenreMaps",
                keyColumn: "BookGenreMapID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BookGenreMaps",
                keyColumn: "BookGenreMapID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BookGenreMaps",
                keyColumn: "BookGenreMapID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BookGenreMaps",
                keyColumn: "BookGenreMapID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BookGenreMaps",
                keyColumn: "BookGenreMapID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BookGenreMaps",
                keyColumn: "BookGenreMapID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BookGenreMaps",
                keyColumn: "BookGenreMapID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "BookGenreMaps",
                keyColumn: "BookGenreMapID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "BookGenreMaps",
                keyColumn: "BookGenreMapID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "BookGenreMaps",
                keyColumn: "BookGenreMapID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "BookGenreMaps",
                keyColumn: "BookGenreMapID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "BookGenreMaps",
                keyColumn: "BookGenreMapID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "BookGenreMaps",
                keyColumn: "BookGenreMapID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "BookGenreMaps",
                keyColumn: "BookGenreMapID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "BookGenreMaps",
                keyColumn: "BookGenreMapID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "BookGenreMaps",
                keyColumn: "BookGenreMapID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "BookGenreMaps",
                keyColumn: "BookGenreMapID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "BookGenreMaps",
                keyColumn: "BookGenreMapID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorID",
                keyValue: 5);
        }
    }
}
