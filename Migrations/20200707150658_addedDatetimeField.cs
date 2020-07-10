using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QulificationToolForCreditCard.Migrations
{
    public partial class addedDatetimeField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateTime",
                table: "Customers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Customers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateTime",
                table: "CardDetails",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "CardDetails",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CardDetails",
                keyColumn: "CreditCardId",
                keyValue: 1,
                columns: new[] { "CreatedDateTime", "ModifiedDateTime" },
                values: new object[] { new DateTime(2020, 7, 7, 17, 6, 58, 207, DateTimeKind.Local), new DateTime(2020, 7, 7, 17, 6, 58, 211, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "CardDetails",
                keyColumn: "CreditCardId",
                keyValue: 2,
                columns: new[] { "CreatedDateTime", "ModifiedDateTime" },
                values: new object[] { new DateTime(2020, 7, 7, 17, 6, 58, 212, DateTimeKind.Local), new DateTime(2020, 7, 7, 17, 6, 58, 212, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "CardDetails",
                keyColumn: "CreditCardId",
                keyValue: 3,
                columns: new[] { "CreatedDateTime", "ModifiedDateTime" },
                values: new object[] { new DateTime(2020, 7, 7, 17, 6, 58, 212, DateTimeKind.Local), new DateTime(2020, 7, 7, 17, 6, 58, 212, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "CardDetails");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "CardDetails");
        }
    }
}
