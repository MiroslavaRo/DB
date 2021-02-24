using Microsoft.EntityFrameworkCore.Migrations;

namespace task_02.Migrations
{
    public partial class FirstDatas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuthorBookGenreMaps_Authors_AuthorID",
                table: "AuthorBookGenreMaps");

            migrationBuilder.DropForeignKey(
                name: "FK_AuthorBookGenreMaps_Books_BookID",
                table: "AuthorBookGenreMaps");

            migrationBuilder.DropForeignKey(
                name: "FK_AuthorBookGenreMaps_Geners_GenreID",
                table: "AuthorBookGenreMaps");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Geners_GenreID",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_GenreID",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_AuthorBookGenreMaps_AuthorID",
                table: "AuthorBookGenreMaps");

            migrationBuilder.DropColumn(
                name: "GenreID",
                table: "Books");

            migrationBuilder.AlterColumn<int>(
                name: "GenreID",
                table: "AuthorBookGenreMaps",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BookID",
                table: "AuthorBookGenreMaps",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AuthorID",
                table: "AuthorBookGenreMaps",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorID", "AuthorName" },
                values: new object[] { 1, "Sapkowski" });

            migrationBuilder.InsertData(
                table: "Geners",
                columns: new[] { "GenreID", "GenreName" },
                values: new object[,]
                {
                    { 1, "fantasy" },
                    { 2, "war film" },
                    { 3, "drama" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookID", "AuthorID", "BookName", "BookYear" },
                values: new object[] { 1, 1, "Witcher:The Last Wish", 1993 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookID", "AuthorID", "BookName", "BookYear" },
                values: new object[] { 2, 1, "The Snake", 2009 });

            migrationBuilder.InsertData(
                table: "AuthorBookGenreMaps",
                columns: new[] { "AuthorBookGenreMapID", "AuthorID", "BookID", "GenreID" },
                values: new object[] { 1, 1, 2, 1 });

            migrationBuilder.InsertData(
                table: "AuthorBookGenreMaps",
                columns: new[] { "AuthorBookGenreMapID", "AuthorID", "BookID", "GenreID" },
                values: new object[] { 2, 1, 2, 2 });

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorBookGenreMaps_Books_BookID",
                table: "AuthorBookGenreMaps",
                column: "BookID",
                principalTable: "Books",
                principalColumn: "BookID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorBookGenreMaps_Geners_GenreID",
                table: "AuthorBookGenreMaps",
                column: "GenreID",
                principalTable: "Geners",
                principalColumn: "GenreID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuthorBookGenreMaps_Books_BookID",
                table: "AuthorBookGenreMaps");

            migrationBuilder.DropForeignKey(
                name: "FK_AuthorBookGenreMaps_Geners_GenreID",
                table: "AuthorBookGenreMaps");

            migrationBuilder.DeleteData(
                table: "AuthorBookGenreMaps",
                keyColumn: "AuthorBookGenreMapID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AuthorBookGenreMaps",
                keyColumn: "AuthorBookGenreMapID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Geners",
                keyColumn: "GenreID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Geners",
                keyColumn: "GenreID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Geners",
                keyColumn: "GenreID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorID",
                keyValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "GenreID",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "GenreID",
                table: "AuthorBookGenreMaps",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BookID",
                table: "AuthorBookGenreMaps",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AuthorID",
                table: "AuthorBookGenreMaps",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Books_GenreID",
                table: "Books",
                column: "GenreID");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorBookGenreMaps_AuthorID",
                table: "AuthorBookGenreMaps",
                column: "AuthorID");

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorBookGenreMaps_Authors_AuthorID",
                table: "AuthorBookGenreMaps",
                column: "AuthorID",
                principalTable: "Authors",
                principalColumn: "AuthorID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorBookGenreMaps_Books_BookID",
                table: "AuthorBookGenreMaps",
                column: "BookID",
                principalTable: "Books",
                principalColumn: "BookID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorBookGenreMaps_Geners_GenreID",
                table: "AuthorBookGenreMaps",
                column: "GenreID",
                principalTable: "Geners",
                principalColumn: "GenreID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Geners_GenreID",
                table: "Books",
                column: "GenreID",
                principalTable: "Geners",
                principalColumn: "GenreID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
