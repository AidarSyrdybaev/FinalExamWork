using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalExamWork.DAL.Migrations
{
    public partial class secondmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Raiting",
                table: "Shops",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Raiting",
                table: "Shops",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
