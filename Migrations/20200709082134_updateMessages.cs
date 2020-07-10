using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QulificationToolForCreditCard.Migrations
{
    public partial class updateMessages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CardDetails",
                keyColumn: "CreditCardId",
                keyValue: 1,
                columns: new[] { "CreatedDateTime", "ModifiedDateTime" },
                values: new object[] { new DateTime(2020, 7, 9, 10, 21, 33, 758, DateTimeKind.Local), new DateTime(2020, 7, 9, 10, 21, 33, 762, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "CardDetails",
                keyColumn: "CreditCardId",
                keyValue: 2,
                columns: new[] { "CreatedDateTime", "Message", "ModifiedDateTime" },
                values: new object[] { new DateTime(2020, 7, 9, 10, 21, 33, 763, DateTimeKind.Local), "Enjoy the Barclay credit card, Barclay credit card now offers an APR of 24.60 %", new DateTime(2020, 7, 9, 10, 21, 33, 763, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "CardDetails",
                keyColumn: "CreditCardId",
                keyValue: 3,
                columns: new[] { "CreatedDateTime", "Message", "ModifiedDateTime" },
                values: new object[] { new DateTime(2020, 7, 9, 10, 21, 33, 763, DateTimeKind.Local), "Enjoy the Vanquis credit card, Vanquis credit card now offers an APR of 36.80 %", new DateTime(2020, 7, 9, 10, 21, 33, 763, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CardDetails",
                keyColumn: "CreditCardId",
                keyValue: 1,
                columns: new[] { "CreatedDateTime", "ModifiedDateTime" },
                values: new object[] { new DateTime(2020, 7, 9, 10, 18, 53, 943, DateTimeKind.Local), new DateTime(2020, 7, 9, 10, 18, 53, 946, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "CardDetails",
                keyColumn: "CreditCardId",
                keyValue: 2,
                columns: new[] { "CreatedDateTime", "Message", "ModifiedDateTime" },
                values: new object[] { new DateTime(2020, 7, 9, 10, 18, 53, 947, DateTimeKind.Local), "Enjoy the Barclay credit card, Barclay credit card now offers an APR of 24.6 %", new DateTime(2020, 7, 9, 10, 18, 53, 947, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "CardDetails",
                keyColumn: "CreditCardId",
                keyValue: 3,
                columns: new[] { "CreatedDateTime", "Message", "ModifiedDateTime" },
                values: new object[] { new DateTime(2020, 7, 9, 10, 18, 53, 947, DateTimeKind.Local), "Enjoy the Vanquis credit card, Vanquis credit card now offers an APR of 36.8 %", new DateTime(2020, 7, 9, 10, 18, 53, 947, DateTimeKind.Local) });
        }
    }
}
