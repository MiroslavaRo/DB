using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace task02.Migrations
{
    public partial class ChangeBookYearType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "BookYear",
                table: "Books",
                type: "int",
                maxLength: 4,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "BookYear",
                table: "Books",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 4);
        }
    }
}
