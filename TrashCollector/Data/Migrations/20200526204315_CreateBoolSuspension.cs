using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class CreateBoolSuspension : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "IsSuspended",
                table: "Customers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d8827fac-4f79-47a5-baad-65ebf4428403", "e85f8fd8-601d-455c-b949-af6b6b58651e", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9bfcaee3-f277-444b-b1b5-07d8ae5bd9fd", "23627e2a-190a-4fd6-bae4-8885fead2fee", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c95ce132-7bf6-44a6-85f8-6efcccbd2a4d", "6585ce1f-110e-4bc4-9d45-6206894affd2", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9bfcaee3-f277-444b-b1b5-07d8ae5bd9fd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c95ce132-7bf6-44a6-85f8-6efcccbd2a4d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8827fac-4f79-47a5-baad-65ebf4428403");

            migrationBuilder.DropColumn(
                name: "IsSuspended",
                table: "Customers");

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
    }
}
