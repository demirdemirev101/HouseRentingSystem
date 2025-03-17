using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Data.Migrations
{
    public partial class BetterSeededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e92ce46-0c8b-4b60-829d-2ae2e7401134", "AQAAAAEAACcQAAAAEHjKb6i/SPrOaLCX9uQ80y2Fwy5drcA0Q9lQB8f47S+qgUImavB1AXbrM8U5bGzmcA==", "8b0ef9bf-810d-4d34-932e-b20160f6febf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b1d88ca-a8d6-4ff3-a87d-0d0c7b00e54d", "AQAAAAEAACcQAAAAENsJLPZjUJMIyFlCBy7xlI/V3znO8jjBfWP0T0Pei/55JpQdqZ5EKQY7xQvwSj39qg==", "c49ef22a-9bc1-4eab-9b99-bde8f649dbd7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9351f3c-78c7-4ae5-9356-3c960c2751f6", "AQAAAAEAACcQAAAAEIB/rBrFSsAdFVoF1/LCrX02yB1r4JL2HjpTX7xBrYfA+KNUs43T4Ihc/ZjnHHzUfA==", "900e157a-7d6e-4ea7-b622-910eb1c60383" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cec4191c-48ff-4d7b-bcf7-828e9b81ae63", "AQAAAAEAACcQAAAAEPdkT8f2snRiGIhWIdU5cwR2MHRHa69FGW95hZO6ccHuwCIT+adbV0455eszTnrZyg==", "871dad2a-aaf4-434c-88e2-93a31bf1c794" });
        }
    }
}
