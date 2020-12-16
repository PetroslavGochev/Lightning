using Microsoft.EntityFrameworkCore.Migrations;

namespace Lightning.Data.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Requests_AspNetUsers_UserId1",
                table: "Requests");

            migrationBuilder.DropIndex(
                name: "IX_Requests_UserId1",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Requests");

            migrationBuilder.AddColumn<string>(
                name: "LightningUserId",
                table: "Requests",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Requests_LightningUserId",
                table: "Requests",
                column: "LightningUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_AspNetUsers_LightningUserId",
                table: "Requests",
                column: "LightningUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Requests_AspNetUsers_LightningUserId",
                table: "Requests");

            migrationBuilder.DropIndex(
                name: "IX_Requests_LightningUserId",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "LightningUserId",
                table: "Requests");

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Requests",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Requests_UserId1",
                table: "Requests",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_AspNetUsers_UserId1",
                table: "Requests",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
