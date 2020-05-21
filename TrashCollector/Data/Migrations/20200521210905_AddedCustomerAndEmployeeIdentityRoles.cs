using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class AddedCustomerAndEmployeeIdentityRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "718386ed-6b97-4736-aa3f-6991ddf1b506");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e1ebf03b-540f-4acc-970a-f1ba903b5b18", "018d8822-d730-4b4b-8671-bda0fd31699c", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c3f0df73-d036-4b38-8ce2-d6feb5c7d583", "528f121b-c10b-4067-bab9-44683c4dfcdc", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f78f9067-c0fd-4bdd-a0fd-f40f165b84aa", "1fe023ee-c849-4b12-9ff9-4687ccf8a8bd", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3f0df73-d036-4b38-8ce2-d6feb5c7d583");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e1ebf03b-540f-4acc-970a-f1ba903b5b18");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f78f9067-c0fd-4bdd-a0fd-f40f165b84aa");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "718386ed-6b97-4736-aa3f-6991ddf1b506", "f604a5c4-cdfd-424a-bf89-97babc8569dd", "Admin", "ADMIN" });
        }
    }
}
