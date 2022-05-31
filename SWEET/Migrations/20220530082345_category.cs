using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SWEET.Migrations
{
    public partial class category : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MaintenanceIssue_AspNetUsers_UserId",
                table: "MaintenanceIssue");

            migrationBuilder.DropForeignKey(
                name: "FK_MaintenanceIssue_Assets_AssetId",
                table: "MaintenanceIssue");

            migrationBuilder.DropForeignKey(
                name: "FK_MaintenanceIssue_Rooms_RoomId",
                table: "MaintenanceIssue");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MaintenanceIssue",
                table: "MaintenanceIssue");

            migrationBuilder.RenameTable(
                name: "MaintenanceIssue",
                newName: "MaintenanceIssueModel");

            migrationBuilder.RenameIndex(
                name: "IX_MaintenanceIssue_UserId",
                table: "MaintenanceIssueModel",
                newName: "IX_MaintenanceIssueModel_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_MaintenanceIssue_RoomId",
                table: "MaintenanceIssueModel",
                newName: "IX_MaintenanceIssueModel_RoomId");

            migrationBuilder.RenameIndex(
                name: "IX_MaintenanceIssue_AssetId",
                table: "MaintenanceIssueModel",
                newName: "IX_MaintenanceIssueModel_AssetId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MaintenanceIssueModel",
                table: "MaintenanceIssueModel",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "CategoryModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryModel", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27b9af34-a133-43e2-8dd2-aef04ddb2b8c",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAEAACcQAAAAEJaKlUYZoJ/trqxGWYBXiuhQZm8cN/Xi+U+b+gFJfW3PFloUkVur+CBACQnGnvX++Q==", "1463c53c-fcd4-4201-ae48-e7bd48d25d80" });

            migrationBuilder.AddForeignKey(
                name: "FK_MaintenanceIssueModel_AspNetUsers_UserId",
                table: "MaintenanceIssueModel",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaintenanceIssueModel_Assets_AssetId",
                table: "MaintenanceIssueModel",
                column: "AssetId",
                principalTable: "Assets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaintenanceIssueModel_Rooms_RoomId",
                table: "MaintenanceIssueModel",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MaintenanceIssueModel_AspNetUsers_UserId",
                table: "MaintenanceIssueModel");

            migrationBuilder.DropForeignKey(
                name: "FK_MaintenanceIssueModel_Assets_AssetId",
                table: "MaintenanceIssueModel");

            migrationBuilder.DropForeignKey(
                name: "FK_MaintenanceIssueModel_Rooms_RoomId",
                table: "MaintenanceIssueModel");

            migrationBuilder.DropTable(
                name: "CategoryModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MaintenanceIssueModel",
                table: "MaintenanceIssueModel");

            migrationBuilder.RenameTable(
                name: "MaintenanceIssueModel",
                newName: "MaintenanceIssue");

            migrationBuilder.RenameIndex(
                name: "IX_MaintenanceIssueModel_UserId",
                table: "MaintenanceIssue",
                newName: "IX_MaintenanceIssue_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_MaintenanceIssueModel_RoomId",
                table: "MaintenanceIssue",
                newName: "IX_MaintenanceIssue_RoomId");

            migrationBuilder.RenameIndex(
                name: "IX_MaintenanceIssueModel_AssetId",
                table: "MaintenanceIssue",
                newName: "IX_MaintenanceIssue_AssetId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MaintenanceIssue",
                table: "MaintenanceIssue",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27b9af34-a133-43e2-8dd2-aef04ddb2b8c",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAEAACcQAAAAEA15sCYxv9jBRk9rpWdzRZeq4DeOMUPSycKD/vNHMnOVibU+t8zkdqUdJeIUkRuI/w==", "1325e6d6-5608-4df0-9086-ed272fd6052b" });

            migrationBuilder.AddForeignKey(
                name: "FK_MaintenanceIssue_AspNetUsers_UserId",
                table: "MaintenanceIssue",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaintenanceIssue_Assets_AssetId",
                table: "MaintenanceIssue",
                column: "AssetId",
                principalTable: "Assets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaintenanceIssue_Rooms_RoomId",
                table: "MaintenanceIssue",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
