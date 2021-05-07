using Microsoft.EntityFrameworkCore.Migrations;

namespace CGLogistics.Data.Migrations
{
    public partial class editOrderFields1pleases : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_OrderDetails_OrderDetailsId",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_OrderDetailsId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "OrderDetailsId",
                table: "Order");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderDetailsId",
                table: "Order",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Order_OrderDetailsId",
                table: "Order",
                column: "OrderDetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_OrderDetails_OrderDetailsId",
                table: "Order",
                column: "OrderDetailsId",
                principalTable: "OrderDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
