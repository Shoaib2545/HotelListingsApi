using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelListings.Migrations
{
    public partial class AddedDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6335c4b1-a1c3-428f-8822-04908751daa2", "85a79ea8-a32d-4493-9585-91c68c49f455", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b69f6452-ee98-40d8-96bc-f73c221551bb", "a2d38f3b-8333-435f-838b-628b7447eb44", "user", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6335c4b1-a1c3-428f-8822-04908751daa2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b69f6452-ee98-40d8-96bc-f73c221551bb");
        }
    }
}
