using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrpjetPFA.Data.Migrations
{
    /// <inheritdoc />
    public partial class m6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Filiere_EcolePrive_EcolePriveId",
                table: "Filiere");

            migrationBuilder.RenameColumn(
                name: "EcolePriveId",
                table: "Filiere",
                newName: "EcoleId");

            migrationBuilder.RenameIndex(
                name: "IX_Filiere_EcolePriveId",
                table: "Filiere",
                newName: "IX_Filiere_EcoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Filiere_EcolePrive_EcoleId",
                table: "Filiere",
                column: "EcoleId",
                principalTable: "EcolePrive",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Filiere_EcolePrive_EcoleId",
                table: "Filiere");

            migrationBuilder.RenameColumn(
                name: "EcoleId",
                table: "Filiere",
                newName: "EcolePriveId");

            migrationBuilder.RenameIndex(
                name: "IX_Filiere_EcoleId",
                table: "Filiere",
                newName: "IX_Filiere_EcolePriveId");

            migrationBuilder.AddForeignKey(
                name: "FK_Filiere_EcolePrive_EcolePriveId",
                table: "Filiere",
                column: "EcolePriveId",
                principalTable: "EcolePrive",
                principalColumn: "Id");
        }
    }
}
