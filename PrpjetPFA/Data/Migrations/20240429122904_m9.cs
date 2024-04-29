using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrpjetPFA.Data.Migrations
{
    /// <inheritdoc />
    public partial class m9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AcreditationCertification",
                table: "Faculte");

            migrationBuilder.DropColumn(
                name: "CoutETAideFinanciere",
                table: "Faculte");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AcreditationCertification",
                table: "Faculte",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "CoutETAideFinanciere",
                table: "Faculte",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
