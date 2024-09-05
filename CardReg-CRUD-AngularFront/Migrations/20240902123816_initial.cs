using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CardReg_CRUD_AngularFront.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HolderName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpireMonth = table.Column<int>(type: "int", nullable: false),
                    ExpireYear = table.Column<int>(type: "int", nullable: false),
                    CVC = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "CVC", "CardNumber", "ExpireMonth", "ExpireYear", "HolderName" },
                values: new object[,]
                {
                    { new Guid("808b4920-c29b-48c1-b8a9-a13e85d23c7e"), 123, "12345678910111213", 1, 2025, "Card Holder One" },
                    { new Guid("86a58489-5bb3-4720-beb1-a1a9694c4bec"), 789, "52345678910111215", 3, 2027, "Card Holder Three" },
                    { new Guid("f6178836-eb0c-49fb-ad6b-304a6f6145c1"), 456, "42345678910111214", 2, 2022, "Card Holder Two" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cards");
        }
    }
}
