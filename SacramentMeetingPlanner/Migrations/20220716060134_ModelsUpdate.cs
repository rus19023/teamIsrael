using Microsoft.EntityFrameworkCore.Migrations;

namespace SacramentMeetingPlanner.Migrations
{
    public partial class ModelsUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Meeting_MemberID",
                table: "Meeting");

            migrationBuilder.CreateIndex(
                name: "IX_Meeting_MemberID",
                table: "Meeting",
                column: "MemberID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Meeting_MemberID",
                table: "Meeting");

            migrationBuilder.CreateIndex(
                name: "IX_Meeting_MemberID",
                table: "Meeting",
                column: "MemberID",
                unique: true);
        }
    }
}
