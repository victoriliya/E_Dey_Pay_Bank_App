using Microsoft.EntityFrameworkCore.Migrations;

namespace CGLogistics.Data.Migrations
{
    public partial class editcustomeraddressstateid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomersAddress_State_StateId",
                table: "CustomersAddress");

            migrationBuilder.DropIndex(
                name: "IX_CustomersAddress_StateId",
                table: "CustomersAddress");

            migrationBuilder.AlterColumn<int>(
                name: "StateId",
                table: "CustomersAddress",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "StateId",
                table: "CustomersAddress",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersAddress_StateId",
                table: "CustomersAddress",
                column: "StateId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomersAddress_State_StateId",
                table: "CustomersAddress",
                column: "StateId",
                principalTable: "State",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
