using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QulificationToolForCreditCard.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CardDetails",
                columns: table => new
                {
                    CreditCardId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nvarchar50 = table.Column<string>(name: "nvarchar(50", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardDetails", x => x.CreditCardId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nvarchar50 = table.Column<string>(name: "nvarchar(50", nullable: false),
                    DOB = table.Column<DateTime>(nullable: false),
                    Annual_Income = table.Column<decimal>(nullable: false),
                    CreditCardId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_Customers_CardDetails_CreditCardId",
                        column: x => x.CreditCardId,
                        principalTable: "CardDetails",
                        principalColumn: "CreditCardId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CreditCardId",
                table: "Customers",
                column: "CreditCardId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "CardDetails");
        }
    }
}
