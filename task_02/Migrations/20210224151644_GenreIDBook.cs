using Microsoft.EntityFrameworkCore.Migrations;

namespace task_02.Migrations
{
    public partial class GenreIDBook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GenreID",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);
           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GenreID",
                table: "Books");
        }

    }
}
