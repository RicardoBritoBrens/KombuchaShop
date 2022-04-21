using Microsoft.EntityFrameworkCore.Migrations;

namespace KombuchaShop.Migrations
{
    public partial class RenamePieIdAsKombuchaIdIntoOrderClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Kombuchas_KombuchaId",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "PieId",
                table: "OrderDetails");

            migrationBuilder.AlterColumn<int>(
                name: "KombuchaId",
                table: "OrderDetails",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Kombuchas_KombuchaId",
                table: "OrderDetails",
                column: "KombuchaId",
                principalTable: "Kombuchas",
                principalColumn: "KombuchaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Kombuchas_KombuchaId",
                table: "OrderDetails");

            migrationBuilder.AlterColumn<int>(
                name: "KombuchaId",
                table: "OrderDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "PieId",
                table: "OrderDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Kombuchas_KombuchaId",
                table: "OrderDetails",
                column: "KombuchaId",
                principalTable: "Kombuchas",
                principalColumn: "KombuchaId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
