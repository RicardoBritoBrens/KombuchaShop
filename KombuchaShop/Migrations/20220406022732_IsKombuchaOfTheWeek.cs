using Microsoft.EntityFrameworkCore.Migrations;

namespace KombuchaShop.Migrations
{
    public partial class IsKombuchaOfTheWeek : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsKombuchaOfTheWeek",
                table: "Kombuchas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Kombuchas",
                keyColumn: "KombuchaId",
                keyValue: 1,
                column: "IsKombuchaOfTheWeek",
                value: true);

            migrationBuilder.UpdateData(
                table: "Kombuchas",
                keyColumn: "KombuchaId",
                keyValue: 2,
                column: "IsKombuchaOfTheWeek",
                value: true);

            migrationBuilder.UpdateData(
                table: "Kombuchas",
                keyColumn: "KombuchaId",
                keyValue: 3,
                column: "IsKombuchaOfTheWeek",
                value: true);

            migrationBuilder.UpdateData(
                table: "Kombuchas",
                keyColumn: "KombuchaId",
                keyValue: 4,
                column: "IsKombuchaOfTheWeek",
                value: false);

            migrationBuilder.UpdateData(
                table: "Kombuchas",
                keyColumn: "KombuchaId",
                keyValue: 5,
                column: "IsKombuchaOfTheWeek",
                value: false);

            migrationBuilder.UpdateData(
                table: "Kombuchas",
                keyColumn: "KombuchaId",
                keyValue: 6,
                column: "IsKombuchaOfTheWeek",
                value: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsKombuchaOfTheWeek",
                table: "Kombuchas");
        }
    }
}