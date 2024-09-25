using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IdentidadIntegral.Migrations
{
    /// <inheritdoc />
    public partial class RemoveCompanyfromproject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Companies_CompanyIdCompany",
                table: "Projects");

            migrationBuilder.AlterColumn<int>(
                name: "CompanyIdCompany",
                table: "Projects",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Companies_CompanyIdCompany",
                table: "Projects",
                column: "CompanyIdCompany",
                principalTable: "Companies",
                principalColumn: "IdCompany");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Companies_CompanyIdCompany",
                table: "Projects");

            migrationBuilder.AlterColumn<int>(
                name: "CompanyIdCompany",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Companies_CompanyIdCompany",
                table: "Projects",
                column: "CompanyIdCompany",
                principalTable: "Companies",
                principalColumn: "IdCompany",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
