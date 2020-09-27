using Microsoft.EntityFrameworkCore.Migrations;

namespace Contab.Migrations
{
    public partial class Added_CardType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CardTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 15, nullable: false),
                    Description = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardTypes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "CardTypes",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 1, null, "Debit" });

            migrationBuilder.InsertData(
                table: "CardTypes",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 2, null, "Credit" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardTypes");
        }
    }
}
