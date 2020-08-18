using Microsoft.EntityFrameworkCore.Migrations;

namespace TestTaskToALEF.Migrations
{
    public partial class _423 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_models",
                table: "models");

            migrationBuilder.RenameTable(
                name: "models",
                newName: "Models");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Models",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20) CHARACTER SET utf8mb4",
                oldMaxLength: 20);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Models",
                table: "Models",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Models",
                table: "Models");

            migrationBuilder.RenameTable(
                name: "Models",
                newName: "models");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "models",
                type: "varchar(20) CHARACTER SET utf8mb4",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_models",
                table: "models",
                column: "Id");
        }
    }
}
