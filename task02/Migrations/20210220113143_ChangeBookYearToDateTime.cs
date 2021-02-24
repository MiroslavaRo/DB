using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace task02.Migrations
{
    public partial class ChangeBookYearToDateTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "BookYear",
                table: "Books",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "BookYear",
                table: "Books",
                type: "int",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");
        }
    }
}
