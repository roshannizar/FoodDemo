using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodDemo.Data.Migrations
{
    public partial class InitSix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_OrderLines_OrderLineId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_OrderLineId",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "OrderLineId",
                table: "OrderLines",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderLines_Orders_OrderLineId",
                table: "OrderLines");

            migrationBuilder.DropIndex(
                name: "IX_OrderLines_OrderLineId",
                table: "OrderLines");

            migrationBuilder.DropColumn(
                name: "OrderLineId",
                table: "OrderLines");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderLineId",
                table: "Orders",
                column: "OrderLineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_OrderLines_OrderLineId",
                table: "Orders",
                column: "OrderLineId",
                principalTable: "OrderLines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
