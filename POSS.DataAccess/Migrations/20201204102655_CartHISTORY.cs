using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace POSS.DataAccess.Migrations
{
    public partial class CartHISTORY : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartHistories",
                columns: table => new
                {
                    CartHistoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserCartId = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    DateRecorded = table.Column<DateTime>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartHistories", x => x.CartHistoryId);
                });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 12, 4, 12, 26, 54, 635, DateTimeKind.Local).AddTicks(7318));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2020, 12, 4, 12, 26, 54, 637, DateTimeKind.Local).AddTicks(2518));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2020, 12, 4, 12, 26, 54, 637, DateTimeKind.Local).AddTicks(2553));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 100,
                column: "OrderDate",
                value: new DateTime(2020, 12, 4, 12, 26, 54, 640, DateTimeKind.Local).AddTicks(8273));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 101,
                column: "OrderDate",
                value: new DateTime(2020, 12, 4, 12, 26, 54, 640, DateTimeKind.Local).AddTicks(4439));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 100,
                column: "PaymentDate",
                value: new DateTime(2020, 12, 4, 12, 26, 54, 643, DateTimeKind.Local).AddTicks(2949));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 101,
                column: "PaymentDate",
                value: new DateTime(2020, 12, 4, 12, 26, 54, 643, DateTimeKind.Local).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 12, 4, 12, 26, 54, 639, DateTimeKind.Local).AddTicks(293));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2020, 12, 4, 12, 26, 54, 639, DateTimeKind.Local).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2020, 12, 4, 12, 26, 54, 640, DateTimeKind.Local).AddTicks(701));

            migrationBuilder.UpdateData(
                table: "SubGroups",
                keyColumn: "SubGroup_Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 12, 4, 12, 26, 54, 637, DateTimeKind.Local).AddTicks(5995));

            migrationBuilder.UpdateData(
                table: "SubGroups",
                keyColumn: "SubGroup_Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2020, 12, 4, 12, 26, 54, 637, DateTimeKind.Local).AddTicks(6991));

            migrationBuilder.UpdateData(
                table: "SubGroups",
                keyColumn: "SubGroup_Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2020, 12, 4, 12, 26, 54, 637, DateTimeKind.Local).AddTicks(7018));

            migrationBuilder.UpdateData(
                table: "SubGroups",
                keyColumn: "SubGroup_Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2020, 12, 4, 12, 26, 54, 637, DateTimeKind.Local).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "SubGroups",
                keyColumn: "SubGroup_Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2020, 12, 4, 12, 26, 54, 637, DateTimeKind.Local).AddTicks(7022));

            migrationBuilder.UpdateData(
                table: "SubGroups",
                keyColumn: "SubGroup_Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2020, 12, 4, 12, 26, 54, 637, DateTimeKind.Local).AddTicks(7024));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "EndTime", "Parameters", "StartTime" },
                values: new object[] { new DateTime(2020, 12, 4, 12, 26, 56, 641, DateTimeKind.Local).AddTicks(2751), "Lungapt@gmail.com|0.00|1|2020/12/04 12:26:54|Create|900.00|15", new DateTime(2020, 12, 4, 12, 26, 55, 641, DateTimeKind.Local).AddTicks(2010) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "EndTime", "Parameters", "StartTime" },
                values: new object[] { new DateTime(2020, 12, 4, 12, 26, 56, 642, DateTimeKind.Local).AddTicks(9791), "Lungapt@gmail.com|0.00|2|2020/12/04 12:26:54|Create|1800.00|15", new DateTime(2020, 12, 4, 12, 26, 55, 642, DateTimeKind.Local).AddTicks(9762) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartHistories");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 12, 2, 18, 57, 40, 41, DateTimeKind.Local).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2020, 12, 2, 18, 57, 40, 42, DateTimeKind.Local).AddTicks(8081));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2020, 12, 2, 18, 57, 40, 42, DateTimeKind.Local).AddTicks(8112));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 100,
                column: "OrderDate",
                value: new DateTime(2020, 12, 2, 18, 57, 40, 46, DateTimeKind.Local).AddTicks(1005));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 101,
                column: "OrderDate",
                value: new DateTime(2020, 12, 2, 18, 57, 40, 45, DateTimeKind.Local).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 100,
                column: "PaymentDate",
                value: new DateTime(2020, 12, 2, 18, 57, 40, 48, DateTimeKind.Local).AddTicks(506));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 101,
                column: "PaymentDate",
                value: new DateTime(2020, 12, 2, 18, 57, 40, 48, DateTimeKind.Local).AddTicks(1583));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 12, 2, 18, 57, 40, 44, DateTimeKind.Local).AddTicks(6382));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2020, 12, 2, 18, 57, 40, 45, DateTimeKind.Local).AddTicks(1038));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2020, 12, 2, 18, 57, 40, 45, DateTimeKind.Local).AddTicks(4751));

            migrationBuilder.UpdateData(
                table: "SubGroups",
                keyColumn: "SubGroup_Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 12, 2, 18, 57, 40, 43, DateTimeKind.Local).AddTicks(1344));

            migrationBuilder.UpdateData(
                table: "SubGroups",
                keyColumn: "SubGroup_Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2020, 12, 2, 18, 57, 40, 43, DateTimeKind.Local).AddTicks(2926));

            migrationBuilder.UpdateData(
                table: "SubGroups",
                keyColumn: "SubGroup_Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2020, 12, 2, 18, 57, 40, 43, DateTimeKind.Local).AddTicks(2962));

            migrationBuilder.UpdateData(
                table: "SubGroups",
                keyColumn: "SubGroup_Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2020, 12, 2, 18, 57, 40, 43, DateTimeKind.Local).AddTicks(2966));

            migrationBuilder.UpdateData(
                table: "SubGroups",
                keyColumn: "SubGroup_Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2020, 12, 2, 18, 57, 40, 43, DateTimeKind.Local).AddTicks(2968));

            migrationBuilder.UpdateData(
                table: "SubGroups",
                keyColumn: "SubGroup_Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2020, 12, 2, 18, 57, 40, 43, DateTimeKind.Local).AddTicks(2970));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "EndTime", "Parameters", "StartTime" },
                values: new object[] { new DateTime(2020, 12, 2, 18, 57, 42, 46, DateTimeKind.Local).AddTicks(4017), "Lungapt@gmail.com|0.00|1|2020/12/02 18:57:40|Create|900.00|15", new DateTime(2020, 12, 2, 18, 57, 41, 46, DateTimeKind.Local).AddTicks(3458) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "EndTime", "Parameters", "StartTime" },
                values: new object[] { new DateTime(2020, 12, 2, 18, 57, 42, 47, DateTimeKind.Local).AddTicks(7982), "Lungapt@gmail.com|0.00|2|2020/12/02 18:57:40|Create|1800.00|15", new DateTime(2020, 12, 2, 18, 57, 41, 47, DateTimeKind.Local).AddTicks(7957) });
        }
    }
}
