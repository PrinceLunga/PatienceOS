using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace POSS.DataAccess.Migrations
{
    public partial class SecondCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Carts_CartId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CartId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CartId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Carts");

            migrationBuilder.AddColumn<int>(
                name: "CartId",
                table: "Orders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Total",
                table: "Orders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Carts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Carts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 4, 10, 4, 49, 46, 141, DateTimeKind.Local).AddTicks(29));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2020, 4, 10, 4, 49, 46, 142, DateTimeKind.Local).AddTicks(5353));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2020, 4, 10, 4, 49, 46, 142, DateTimeKind.Local).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 4, 10, 4, 49, 46, 144, DateTimeKind.Local).AddTicks(7632));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2020, 4, 10, 4, 49, 46, 145, DateTimeKind.Local).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2020, 4, 10, 4, 49, 46, 145, DateTimeKind.Local).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "SubGroups",
                keyColumn: "SubGroup_Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 4, 10, 4, 49, 46, 142, DateTimeKind.Local).AddTicks(9785));

            migrationBuilder.UpdateData(
                table: "SubGroups",
                keyColumn: "SubGroup_Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2020, 4, 10, 4, 49, 46, 143, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "SubGroups",
                keyColumn: "SubGroup_Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2020, 4, 10, 4, 49, 46, 143, DateTimeKind.Local).AddTicks(1069));

            migrationBuilder.UpdateData(
                table: "SubGroups",
                keyColumn: "SubGroup_Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2020, 4, 10, 4, 49, 46, 143, DateTimeKind.Local).AddTicks(1069));

            migrationBuilder.UpdateData(
                table: "SubGroups",
                keyColumn: "SubGroup_Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2020, 4, 10, 4, 49, 46, 143, DateTimeKind.Local).AddTicks(1072));

            migrationBuilder.UpdateData(
                table: "SubGroups",
                keyColumn: "SubGroup_Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2020, 4, 10, 4, 49, 46, 143, DateTimeKind.Local).AddTicks(1072));

            migrationBuilder.CreateIndex(
                name: "IX_Carts_OrderId",
                table: "Carts",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_ProductId",
                table: "Carts",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Orders_OrderId",
                table: "Carts",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Products_ProductId",
                table: "Carts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Orders_OrderId",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Products_ProductId",
                table: "Carts");

            migrationBuilder.DropIndex(
                name: "IX_Carts_OrderId",
                table: "Carts");

            migrationBuilder.DropIndex(
                name: "IX_Carts_ProductId",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "CartId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Carts");

            migrationBuilder.AddColumn<int>(
                name: "CartId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Carts",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 4, 10, 3, 40, 24, 94, DateTimeKind.Local).AddTicks(7187));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2020, 4, 10, 3, 40, 24, 96, DateTimeKind.Local).AddTicks(9218));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2020, 4, 10, 3, 40, 24, 96, DateTimeKind.Local).AddTicks(9282));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 4, 10, 3, 40, 24, 99, DateTimeKind.Local).AddTicks(407));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2020, 4, 10, 3, 40, 24, 99, DateTimeKind.Local).AddTicks(6056));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2020, 4, 10, 3, 40, 24, 100, DateTimeKind.Local).AddTicks(742));

            migrationBuilder.UpdateData(
                table: "SubGroups",
                keyColumn: "SubGroup_Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 4, 10, 3, 40, 24, 97, DateTimeKind.Local).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "SubGroups",
                keyColumn: "SubGroup_Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2020, 4, 10, 3, 40, 24, 97, DateTimeKind.Local).AddTicks(4984));

            migrationBuilder.UpdateData(
                table: "SubGroups",
                keyColumn: "SubGroup_Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2020, 4, 10, 3, 40, 24, 97, DateTimeKind.Local).AddTicks(5012));

            migrationBuilder.UpdateData(
                table: "SubGroups",
                keyColumn: "SubGroup_Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2020, 4, 10, 3, 40, 24, 97, DateTimeKind.Local).AddTicks(5012));

            migrationBuilder.UpdateData(
                table: "SubGroups",
                keyColumn: "SubGroup_Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2020, 4, 10, 3, 40, 24, 97, DateTimeKind.Local).AddTicks(5015));

            migrationBuilder.UpdateData(
                table: "SubGroups",
                keyColumn: "SubGroup_Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2020, 4, 10, 3, 40, 24, 97, DateTimeKind.Local).AddTicks(5019));

            migrationBuilder.CreateIndex(
                name: "IX_Products_CartId",
                table: "Products",
                column: "CartId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Carts_CartId",
                table: "Products",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
