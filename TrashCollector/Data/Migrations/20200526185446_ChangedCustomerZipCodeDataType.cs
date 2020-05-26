using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class ChangedCustomerZipCodeDataType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "093e10e0-0ba6-4048-bcc4-b0aabb7df605");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6386589-3d3a-4fbc-a63e-38df0d08d67b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f8ff6faf-9f92-4e2e-8aae-0f2c05d83ee0");

            migrationBuilder.AlterColumn<int>(
                name: "ZipCode",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0137cf89-d08c-4ecc-a028-3f52c29e0a07", "7b869279-f499-47d4-b220-bd05970d12e7", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "53650f31-5a3f-49af-a09a-debcd7fb1885", "cb31b702-7c81-4de7-8eb3-4e91bcd619df", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c9e5b980-c8c9-4b52-bd92-62b36cb554d5", "01372a0b-131d-4a2a-96fc-86098bb4e7ec", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0137cf89-d08c-4ecc-a028-3f52c29e0a07");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "53650f31-5a3f-49af-a09a-debcd7fb1885");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9e5b980-c8c9-4b52-bd92-62b36cb554d5");

            migrationBuilder.AlterColumn<string>(
                name: "ZipCode",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f8ff6faf-9f92-4e2e-8aae-0f2c05d83ee0", "183bfdef-a440-449a-8a5e-9c46617d8783", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "093e10e0-0ba6-4048-bcc4-b0aabb7df605", "c2653e1a-4999-48ce-b269-31143491a866", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f6386589-3d3a-4fbc-a63e-38df0d08d67b", "51105dd7-1213-4f9d-af00-19b1f7c056a3", "Employee", "EMPLOYEE" });
        }
    }
}
