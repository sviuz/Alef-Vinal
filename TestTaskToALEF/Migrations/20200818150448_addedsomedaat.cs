using Microsoft.EntityFrameworkCore.Migrations;

namespace TestTaskToALEF.Migrations
{
    public partial class addedsomedaat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[] { 1, "Vodafone", 66 });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[] { 2, "Lifecell", 93 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
