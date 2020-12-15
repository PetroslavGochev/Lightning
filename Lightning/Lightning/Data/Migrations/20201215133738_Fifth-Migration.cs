using Microsoft.EntityFrameworkCore.Migrations;

namespace Lightning.Data.Migrations
{
    public partial class FifthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LightningUserId",
                table: "Requests",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
    }
}
