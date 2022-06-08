using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MegaDeskv3._0.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DeskQuote",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    width = table.Column<int>(type: "int", nullable: false),
                    depth = table.Column<int>(type: "int", nullable: false),
                    drawers = table.Column<int>(type: "int", nullable: false),
                    surfaceMaterial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    customerFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    customerLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rushDays = table.Column<int>(type: "int", nullable: false),
                    quoteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    quoteTotal = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeskQuote", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeskQuote");
        }
    }
}
