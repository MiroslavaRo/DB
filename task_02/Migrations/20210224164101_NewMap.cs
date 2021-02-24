using Microsoft.EntityFrameworkCore.Migrations;

namespace task_02.Migrations
{
    public partial class NewMap : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AuthorBookGenreMaps",
                columns: new[] { "AuthorBookGenreMapID", "AuthorID", "BookID", "GenreID" },
                values: new object[] { 3, 1, 2, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AuthorBookGenreMaps",
                keyColumn: "AuthorBookGenreMapID",
                keyValue: 3);
        }
    }
}
