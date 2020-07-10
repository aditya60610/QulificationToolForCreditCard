using Microsoft.EntityFrameworkCore.Migrations;

namespace QulificationToolForCreditCard.Migrations
{
    public partial class updatedColumnDetailsAndSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "nvarchar(50",
                table: "Customers",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "nvarchar(50",
                table: "CardDetails",
                newName: "CardName");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Customers",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "CardName",
                table: "CardDetails",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "APR",
                table: "CardDetails",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Message",
                table: "CardDetails",
                nullable: true);

            migrationBuilder.InsertData(
                table: "CardDetails",
                columns: new[] { "CreditCardId", "APR", "CardName", "Message" },
                values: new object[] { 1, 0m, "None", "No credit cards are available" });

            migrationBuilder.InsertData(
                table: "CardDetails",
                columns: new[] { "CreditCardId", "APR", "CardName", "Message" },
                values: new object[] { 2, 24.6m, "Barclay", "Enjoy the Barclay credit card" });

            migrationBuilder.InsertData(
                table: "CardDetails",
                columns: new[] { "CreditCardId", "APR", "CardName", "Message" },
                values: new object[] { 3, 36.8m, "Vanquis", "Enjoy the Vanquis credit card" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CardDetails",
                keyColumn: "CreditCardId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CardDetails",
                keyColumn: "CreditCardId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CardDetails",
                keyColumn: "CreditCardId",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "APR",
                table: "CardDetails");

            migrationBuilder.DropColumn(
                name: "Message",
                table: "CardDetails");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Customers",
                newName: "nvarchar(50");

            migrationBuilder.RenameColumn(
                name: "CardName",
                table: "CardDetails",
                newName: "nvarchar(50");

            migrationBuilder.AlterColumn<string>(
                name: "nvarchar(50",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "nvarchar(50",
                table: "CardDetails",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);
        }
    }
}
