using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SWEET.Migrations
{
    public partial class views : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AssetModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GeneralIssueModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralIssueModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GeneralIssueModel_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoomModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaintenanceIssueModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    AssetId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintenanceIssueModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MaintenanceIssueModel_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaintenanceIssueModel_AssetModel_AssetId",
                        column: x => x.AssetId,
                        principalTable: "AssetModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaintenanceIssueModel_RoomModel_RoomId",
                        column: x => x.RoomId,
                        principalTable: "RoomModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GeneralIssueModel_UserId",
                table: "GeneralIssueModel",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceIssueModel_AssetId",
                table: "MaintenanceIssueModel",
                column: "AssetId");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceIssueModel_RoomId",
                table: "MaintenanceIssueModel",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceIssueModel_UserId",
                table: "MaintenanceIssueModel",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GeneralIssueModel");

            migrationBuilder.DropTable(
                name: "MaintenanceIssueModel");

            migrationBuilder.DropTable(
                name: "AssetModel");

            migrationBuilder.DropTable(
                name: "RoomModel");
        }
    }
}
