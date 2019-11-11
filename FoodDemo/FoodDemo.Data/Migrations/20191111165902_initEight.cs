using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodDemo.Data.Migrations
{
    public partial class initEight : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderLines_Orders_OrderLineId",
                table: "OrderLines");

            migrationBuilder.DropIndex(
                name: "IX_OrderLines_OrderLineId",
                table: "OrderLines");

            migrationBuilder.DropColumn(
                name: "OrderLineId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderLineId",
                table: "OrderLines");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderLineId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrderLineId",
                table: "OrderLines",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderLines_OrderLineId",
                table: "OrderLines",
                column: "OrderLineId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderLines_Orders_OrderLineId",
                table: "OrderLines",
                column: "OrderLineId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
