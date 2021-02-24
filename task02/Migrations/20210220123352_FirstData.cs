using Microsoft.EntityFrameworkCore.Migrations;

namespace task02.Migrations
{
    public partial class FirstData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorID", "AuthorName" },
                values: new object[] { 1, "Sapkowski" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookID", "AuthorID", "BookName", "BookYear" },
                values: new object[] { 1, 1, "The Last Wish", 1993 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorID",
                keyValue: 1);
        }
    }
}
