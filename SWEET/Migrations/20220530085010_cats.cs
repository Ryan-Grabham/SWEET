using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SWEET.Migrations
{
    public partial class cats : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27b9af34-a133-43e2-8dd2-aef04ddb2b8c",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAEAACcQAAAAEGj6naGqLQsg/QnMduxEaUaAlyRSfjt0WUf+VlXpqfXvYyi+K6q0bt5hg3UVfY144Q==", "32382394-afa1-4d24-b865-a187ee4ae7db" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27b9af34-a133-43e2-8dd2-aef04ddb2b8c",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAEAACcQAAAAEJaKlUYZoJ/trqxGWYBXiuhQZm8cN/Xi+U+b+gFJfW3PFloUkVur+CBACQnGnvX++Q==", "1463c53c-fcd4-4201-ae48-e7bd48d25d80" });
        }
    }
}
