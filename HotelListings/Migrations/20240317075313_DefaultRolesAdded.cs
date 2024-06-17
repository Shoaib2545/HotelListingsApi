using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelListings.Migrations
{
    public partial class DefaultRolesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6335c4b1-a1c3-428f-8822-04908751daa2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b69f6452-ee98-40d8-96bc-f73c221551bb");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1db956c7-25a2-4413-b73e-5b4e799f036d", "6c34c865-0865-4ab0-8f46-f195f2533112", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5b15c321-43a3-4dce-8228-d9171a2fd898", "dc02ea83-44fb-4426-92d3-483a9b35ba76", "user", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1db956c7-25a2-4413-b73e-5b4e799f036d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b15c321-43a3-4dce-8228-d9171a2fd898");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6335c4b1-a1c3-428f-8822-04908751daa2", "85a79ea8-a32d-4493-9585-91c68c49f455", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b69f6452-ee98-40d8-96bc-f73c221551bb", "a2d38f3b-8333-435f-838b-628b7447eb44", "user", "USER" });
        }
    }
}
