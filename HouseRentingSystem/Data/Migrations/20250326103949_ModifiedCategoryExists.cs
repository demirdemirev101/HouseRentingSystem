using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Data.Migrations
{
    public partial class ModifiedCategoryExists : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3eb5477-9b1e-44ae-b98c-25ee7db8b5f9", "AQAAAAEAACcQAAAAEOJzTP9KMwPSgd2pNnvl5ZNOwQX5VdNHMszzCj+AzrF5rAHAnry3PxEgA8qheiLleA==", "cbad60fd-224a-4cd4-a76e-c89e19c27a1e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc9ba2c1-44fe-4d8d-9539-b339fca5127b", "AQAAAAEAACcQAAAAEJbT41iLb4bly8/vnmLc2VvReTHWj7Ej0WtFdLMNTUhzYCg3w8l6s4xpC/MrU871bQ==", "19954dfd-7c08-47d3-86c3-5c14d0e72083" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
