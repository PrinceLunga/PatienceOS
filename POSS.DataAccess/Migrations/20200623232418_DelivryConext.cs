using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace POSS.DataAccess.Migrations
{
    public partial class DelivryConext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Deliveries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fullnames = table.Column<string>(nullable: true),
                    RecipientMobileNo = table.Column<string>(nullable: true),
                    StreetAddress = table.Column<string>(nullable: true),
                    Complex = table.Column<string>(nullable: true),
                    isResidential = table.Column<bool>(nullable: false),
                    Suburb = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Province = table.Column<string>(nullable: true),
                    PostalCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deliveries", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Deliveries",
                columns: new[] { "Id", "City", "Complex", "Fullnames", "PostalCode", "Province", "RecipientMobileNo", "StreetAddress", "Suburb", "isResidential" },
                values: new object[,]
                {
                    { 1, "Cape Town", "Devon Square", "Prince Thabane Lunga", "8100", "Western Cape", "0659779508", "70 Exeter Road", "Plumstead", true },
                    { 2, "Cape Town", "La rouge", "Rorbet Smith", "8700", "Western Cape", "0659779507", "12 Dor'Chester", "Park Lands", true },
                    { 3, "Durban", "Renaisense", "Siyanda Mlondo", "4000", "KwaZulu Natal", "0659229507", "SF Mfusi Road", "Durban", true }
                });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 6, 24, 1, 24, 17, 170, DateTimeKind.Local).AddTicks(2832));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2020, 6, 24, 1, 24, 17, 172, DateTimeKind.Local).AddTicks(2205));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2020, 6, 24, 1, 24, 17, 172, DateTimeKind.Local).AddTicks(2248));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 100,
                column: "OrderDate",
                value: new DateTime(2020, 6, 24, 1, 24, 17, 176, DateTimeKind.Local).AddTicks(6805));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 101,
                column: "OrderDate",
                value: new DateTime(2020, 6, 24, 1, 24, 17, 176, DateTimeKind.Local).AddTicks(2605));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 100,
                column: "PaymentDate",
                value: new DateTime(2020, 6, 24, 1, 24, 17, 179, DateTimeKind.Local).AddTicks(7591));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 101,
                column: "PaymentDate",
                value: new DateTime(2020, 6, 24, 1, 24, 17, 179, DateTimeKind.Local).AddTicks(8469));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 6, 24, 1, 24, 17, 174, DateTimeKind.Local).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2020, 6, 24, 1, 24, 17, 175, DateTimeKind.Local).AddTicks(3388));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2020, 6, 24, 1, 24, 17, 175, DateTimeKind.Local).AddTicks(8338));

            migrationBuilder.UpdateData(
                table: "SubGroups",
                keyColumn: "SubGroup_Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 6, 24, 1, 24, 17, 172, DateTimeKind.Local).AddTicks(9935));

            migrationBuilder.UpdateData(
                table: "SubGroups",
                keyColumn: "SubGroup_Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2020, 6, 24, 1, 24, 17, 173, DateTimeKind.Local).AddTicks(1229));

            migrationBuilder.UpdateData(
                table: "SubGroups",
                keyColumn: "SubGroup_Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2020, 6, 24, 1, 24, 17, 173, DateTimeKind.Local).AddTicks(1261));

            migrationBuilder.UpdateData(
                table: "SubGroups",
                keyColumn: "SubGroup_Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2020, 6, 24, 1, 24, 17, 173, DateTimeKind.Local).AddTicks(1261));

            migrationBuilder.UpdateData(
                table: "SubGroups",
                keyColumn: "SubGroup_Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2020, 6, 24, 1, 24, 17, 173, DateTimeKind.Local).AddTicks(1342));

            migrationBuilder.UpdateData(
                table: "SubGroups",
                keyColumn: "SubGroup_Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2020, 6, 24, 1, 24, 17, 173, DateTimeKind.Local).AddTicks(1346));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "EndTime", "Parameters", "StartTime" },
                values: new object[] { new DateTime(2020, 6, 24, 1, 24, 19, 177, DateTimeKind.Local).AddTicks(1554), "Lungapt@gmail.com|0.00|1|2020/06/24 01:24:17|Create|900.00|15", new DateTime(2020, 6, 24, 1, 24, 18, 177, DateTimeKind.Local).AddTicks(750) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "EndTime", "Parameters", "StartTime" },
                values: new object[] { new DateTime(2020, 6, 24, 1, 24, 19, 179, DateTimeKind.Local).AddTicks(3621), "Lungapt@gmail.com|0.00|2|2020/06/24 01:24:17|Create|1800.00|15", new DateTime(2020, 6, 24, 1, 24, 18, 179, DateTimeKind.Local).AddTicks(3589) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Carts");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 6, 7, 16, 30, 46, 361, DateTimeKind.Local).AddTicks(5266));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2020, 6, 7, 16, 30, 46, 364, DateTimeKind.Local).AddTicks(682));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2020, 6, 7, 16, 30, 46, 364, DateTimeKind.Local).AddTicks(725));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 100,
                column: "OrderDate",
                value: new DateTime(2020, 6, 7, 16, 30, 46, 367, DateTimeKind.Local).AddTicks(9735));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 101,
                column: "OrderDate",
                value: new DateTime(2020, 6, 7, 16, 30, 46, 367, DateTimeKind.Local).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 100,
                column: "PaymentDate",
                value: new DateTime(2020, 6, 7, 16, 30, 46, 370, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 101,
                column: "PaymentDate",
                value: new DateTime(2020, 6, 7, 16, 30, 46, 370, DateTimeKind.Local).AddTicks(2846));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 6, 7, 16, 30, 46, 366, DateTimeKind.Local).AddTicks(1188));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2020, 6, 7, 16, 30, 46, 366, DateTimeKind.Local).AddTicks(7531));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2020, 6, 7, 16, 30, 46, 367, DateTimeKind.Local).AddTicks(3589));

            migrationBuilder.UpdateData(
                table: "SubGroups",
                keyColumn: "SubGroup_Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 6, 7, 16, 30, 46, 364, DateTimeKind.Local).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "SubGroups",
                keyColumn: "SubGroup_Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2020, 6, 7, 16, 30, 46, 364, DateTimeKind.Local).AddTicks(5940));

            migrationBuilder.UpdateData(
                table: "SubGroups",
                keyColumn: "SubGroup_Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2020, 6, 7, 16, 30, 46, 364, DateTimeKind.Local).AddTicks(5965));

            migrationBuilder.UpdateData(
                table: "SubGroups",
                keyColumn: "SubGroup_Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2020, 6, 7, 16, 30, 46, 364, DateTimeKind.Local).AddTicks(5965));

            migrationBuilder.UpdateData(
                table: "SubGroups",
                keyColumn: "SubGroup_Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2020, 6, 7, 16, 30, 46, 364, DateTimeKind.Local).AddTicks(5968));

            migrationBuilder.UpdateData(
                table: "SubGroups",
                keyColumn: "SubGroup_Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2020, 6, 7, 16, 30, 46, 364, DateTimeKind.Local).AddTicks(5968));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "EndTime", "Parameters", "StartTime" },
                values: new object[] { new DateTime(2020, 6, 7, 16, 30, 48, 368, DateTimeKind.Local).AddTicks(3646), "Lungapt@gmail.com|0.00|1|2020/06/07 16:30:46|Create|900.00|15", new DateTime(2020, 6, 7, 16, 30, 47, 368, DateTimeKind.Local).AddTicks(2972) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "EndTime", "Parameters", "StartTime" },
                values: new object[] { new DateTime(2020, 6, 7, 16, 30, 48, 369, DateTimeKind.Local).AddTicks(9408), "Lungapt@gmail.com|0.00|2|2020/06/07 16:30:46|Create|1800.00|15", new DateTime(2020, 6, 7, 16, 30, 47, 369, DateTimeKind.Local).AddTicks(9383) });
        }
    }
}
