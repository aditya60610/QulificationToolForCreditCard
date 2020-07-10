using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QulificationToolForCreditCard.Migrations
{
    public partial class updateCreditCardMastermessages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CardDetails",
                keyColumn: "CreditCardId",
                keyValue: 1,
                columns: new[] { "CreatedDateTime", "Message", "ModifiedDateTime" },
                values: new object[] { new DateTime(2020, 7, 9, 10, 18, 53, 943, DateTimeKind.Local), "No credit cards are available for the customer below 18 Age.", new DateTime(2020, 7, 9, 10, 18, 53, 946, DateTimeKind.Local) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CardDetails",
                keyColumn: "CreditCardId",
                keyValue: 1,
                columns: new[] { "CreatedDateTime", "Message", "ModifiedDateTime" },
                values: new object[] { new DateTime(2020, 7, 7, 17, 6, 58, 207, DateTimeKind.Local), "No credit cards are available", new DateTime(2020, 7, 7, 17, 6, 58, 211, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "CardDetails",
                keyColumn: "CreditCardId",
                keyValue: 2,
                columns: new[] { "CreatedDateTime", "Message", "ModifiedDateTime" },
                values: new object[] { new DateTime(2020, 7, 7, 17, 6, 58, 212, DateTimeKind.Local), "Enjoy the Barclay credit card", new DateTime(2020, 7, 7, 17, 6, 58, 212, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "CardDetails",
                keyColumn: "CreditCardId",
                keyValue: 3,
                columns: new[] { "CreatedDateTime", "Message", "ModifiedDateTime" },
                values: new object[] { new DateTime(2020, 7, 7, 17, 6, 58, 212, DateTimeKind.Local), "Enjoy the Vanquis credit card", new DateTime(2020, 7, 7, 17, 6, 58, 212, DateTimeKind.Local) });
        }
    }
}
