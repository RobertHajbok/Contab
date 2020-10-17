using Microsoft.EntityFrameworkCore.Migrations;

namespace Contab.Migrations
{
    public partial class Added_RomanianLeu_Currency : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 3, "Romanian leu", "RON" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
