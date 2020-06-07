using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace POSS.DataAccess.Migrations
{
    public partial class TransactinContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerUsername = table.Column<string>(nullable: true),
                    Amount = table.Column<double>(nullable: false),
                    PaymentDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                });

          

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionName = table.Column<string>(nullable: true),
                    StartTime = table.Column<DateTime>(nullable: false),
                    EndTime = table.Column<DateTime>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    TriggeredAction = table.Column<string>(nullable: true),
                    Success = table.Column<bool>(nullable: false),
                    Failure = table.Column<bool>(nullable: false),
                    Parameters = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                });

           
            

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "Amount", "CustomerUsername", "PaymentDate" },
                values: new object[,]
                {
                    { 100, 1800.0, "Lungapt@gmail.com", new DateTime(2020, 6, 7, 16, 30, 46, 370, DateTimeKind.Local).AddTicks(2250) },
                    { 101, 900.0, "Luthando@gmail.com", new DateTime(2020, 6, 7, 16, 30, 46, 370, DateTimeKind.Local).AddTicks(2846) }
                });


            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "EndTime", "Failure", "Parameters", "StartTime", "Status", "Success", "TransactionName", "TriggeredAction" },
                values: new object[,]
                {
                    { 100, new DateTime(2020, 6, 7, 16, 30, 48, 368, DateTimeKind.Local).AddTicks(3646), false, "Lungapt@gmail.com|0.00|1|2020/06/07 16:30:46|Create|900.00|15", new DateTime(2020, 6, 7, 16, 30, 47, 368, DateTimeKind.Local).AddTicks(2972), "Success", true, null, "Charge" },
                    { 101, new DateTime(2020, 6, 7, 16, 30, 48, 369, DateTimeKind.Local).AddTicks(9408), false, "Lungapt@gmail.com|0.00|2|2020/06/07 16:30:46|Create|1800.00|15", new DateTime(2020, 6, 7, 16, 30, 47, 369, DateTimeKind.Local).AddTicks(9383), "Success", true, null, "Charge" }
                });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "SubGroups");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Groups");
        }
    }
}
