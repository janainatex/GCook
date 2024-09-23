using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GCook.Migrations
{
    /// <inheritdoc />
    public partial class corrigebanco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ddf093a6-6cb5-4ff7-9a64-83da34aee005",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9cc275c-9085-468f-b60b-d9d31fd0313c", "AQAAAAIAAYagAAAAEKg/6FyQqxkF+8Blb0j2mQwgCFSU0h0LxnIvRVfVhxfVOSCk1RgxC2xWwTMTrKC2iw==", "f24b1322-3882-4a37-ac33-748d3bd50eb4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ddf093a6-6cb5-4ff7-9a64-83da34aee005",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8631fc84-ac51-4187-b1eb-5f8ae48ee341", "AQAAAAIAAYagAAAAEKJP07XsTWMjZtD8Fi1GrHf5dK7TtGJdLPWiwhQez6gJQdd005ZiLXIzKFsAEIiijA==", "73a87d92-c266-4e35-a3f2-bca0d8894a9d" });
        }
    }
}
