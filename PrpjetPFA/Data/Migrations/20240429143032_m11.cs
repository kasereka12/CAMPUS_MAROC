using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrpjetPFA.Data.Migrations
{
    /// <inheritdoc />
    public partial class m11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EcoleName",
                table: "Filiere");

            migrationBuilder.DropColumn(
                name: "FaculteName",
                table: "Filiere");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EcoleName",
                table: "Filiere",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FaculteName",
                table: "Filiere",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
