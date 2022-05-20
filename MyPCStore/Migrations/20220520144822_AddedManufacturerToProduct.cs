using Microsoft.EntityFrameworkCore.Migrations;

namespace MyPCStore.Migrations
{
    public partial class AddedManufacturerToProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ManufacturerId",
                table: "Product",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_ManufacturerId",
                table: "Product",
                column: "ManufacturerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Manufacturer_ManufacturerId",
                table: "Product",
                column: "ManufacturerId",
                principalTable: "Manufacturer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Manufacturer_ManufacturerId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_ManufacturerId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ManufacturerId",
                table: "Product");
        }
    }
}
