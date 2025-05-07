using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Data.Migrations
{
    public partial class AddedUserColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "367db7b8-4760-4ed4-b053-fa737e1278e7", "Guest", "User", "AQAAAAEAACcQAAAAEPBi+hbQfj4PXvLs+oS/xTEt82D+ho0jPHEahJ+Xuoh7c6wF14QCFL61pmWG64UkcA==", "60787564-8c67-43cb-9676-3fea3d8da726" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c22a9fe4-e262-410d-86cb-1fde80e523bc", "Agent", "User", "AQAAAAEAACcQAAAAENWDhjZ6rWhzPpyjK/DTfcoplsXp3fZTLWZZo64uZau9c31Gkz68Ifjt2grUNyQVlg==", "62561b96-89dd-4f2b-a981-c9108acbf6c8" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

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
    }
}
