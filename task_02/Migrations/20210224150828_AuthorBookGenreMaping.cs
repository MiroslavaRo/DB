using Microsoft.EntityFrameworkCore.Migrations;

namespace task_02.Migrations
{
    public partial class AuthorBookGenreMaping : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Authors_AuthorID",
                table: "Book");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Book",
                table: "Book");

            migrationBuilder.RenameTable(
                name: "Book",
                newName: "Books");

            migrationBuilder.RenameIndex(
                name: "IX_Book_AuthorID",
                table: "Books",
                newName: "IX_Books_AuthorID");

            migrationBuilder.AlterColumn<int>(
                name: "AuthorID",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                table: "Books",
                column: "BookID");

            migrationBuilder.CreateTable(
                name: "Geners",
                columns: table => new
                {
                    GenreID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenreName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Geners", x => x.GenreID);
                });

            migrationBuilder.CreateTable(
                name: "AuthorBookGenreMaps",
                columns: table => new
                {
                    AuthorBookGenreMapID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorID = table.Column<int>(type: "int", nullable: true),
                    BookID = table.Column<int>(type: "int", nullable: true),
                    GenreID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorBookGenreMaps", x => x.AuthorBookGenreMapID);
                    table.ForeignKey(
                        name: "FK_AuthorBookGenreMaps_Authors_AuthorID",
                        column: x => x.AuthorID,
                        principalTable: "Authors",
                        principalColumn: "AuthorID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AuthorBookGenreMaps_Books_BookID",
                        column: x => x.BookID,
                        principalTable: "Books",
                        principalColumn: "BookID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AuthorBookGenreMaps_Geners_GenreID",
                        column: x => x.GenreID,
                        principalTable: "Geners",
                        principalColumn: "GenreID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorBookGenreMaps_AuthorID",
                table: "AuthorBookGenreMaps",
                column: "AuthorID");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorBookGenreMaps_BookID",
                table: "AuthorBookGenreMaps",
                column: "BookID");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorBookGenreMaps_GenreID",
                table: "AuthorBookGenreMaps",
                column: "GenreID");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_AuthorID",
                table: "Books",
                column: "AuthorID",
                principalTable: "Authors",
                principalColumn: "AuthorID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_AuthorID",
                table: "Books");

            migrationBuilder.DropTable(
                name: "AuthorBookGenreMaps");

            migrationBuilder.DropTable(
                name: "Geners");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                table: "Books");

            migrationBuilder.RenameTable(
                name: "Books",
                newName: "Book");

            migrationBuilder.RenameIndex(
                name: "IX_Books_AuthorID",
                table: "Book",
                newName: "IX_Book_AuthorID");

            migrationBuilder.AlterColumn<int>(
                name: "AuthorID",
                table: "Book",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Book",
                table: "Book",
                column: "BookID");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Authors_AuthorID",
                table: "Book",
                column: "AuthorID",
                principalTable: "Authors",
                principalColumn: "AuthorID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
