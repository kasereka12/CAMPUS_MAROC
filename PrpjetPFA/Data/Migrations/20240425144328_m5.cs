using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrpjetPFA.Data.Migrations
{
    /// <inheritdoc />
    public partial class m5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Etablissement_Etablissement_UniversiteId",
                table: "Etablissement");

            migrationBuilder.DropForeignKey(
                name: "FK_Filiere_Etablissement_EcolePriveId",
                table: "Filiere");

            migrationBuilder.DropForeignKey(
                name: "FK_Filiere_Etablissement_FaculteId",
                table: "Filiere");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Etablissement",
                table: "Etablissement");

            migrationBuilder.DropIndex(
                name: "IX_Etablissement_UniversiteId",
                table: "Etablissement");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Etablissement");

            migrationBuilder.DropColumn(
                name: "UniversiteId",
                table: "Etablissement");

            migrationBuilder.RenameTable(
                name: "Etablissement",
                newName: "Universite");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Universite",
                table: "Universite",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "EcolePrive",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ville = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AcreditationCertification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoutETAideFinanciere = table.Column<double>(type: "float", nullable: false),
                    Critereadmission = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EcolePrive", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Faculte",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ville = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AcreditationCertification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoutETAideFinanciere = table.Column<double>(type: "float", nullable: false),
                    Critereadmission = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UniversiteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculte", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Faculte_Universite_UniversiteId",
                        column: x => x.UniversiteId,
                        principalTable: "Universite",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Faculte_UniversiteId",
                table: "Faculte",
                column: "UniversiteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Filiere_EcolePrive_EcolePriveId",
                table: "Filiere",
                column: "EcolePriveId",
                principalTable: "EcolePrive",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Filiere_Faculte_FaculteId",
                table: "Filiere",
                column: "FaculteId",
                principalTable: "Faculte",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Filiere_EcolePrive_EcolePriveId",
                table: "Filiere");

            migrationBuilder.DropForeignKey(
                name: "FK_Filiere_Faculte_FaculteId",
                table: "Filiere");

            migrationBuilder.DropTable(
                name: "EcolePrive");

            migrationBuilder.DropTable(
                name: "Faculte");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Universite",
                table: "Universite");

            migrationBuilder.RenameTable(
                name: "Universite",
                newName: "Etablissement");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Etablissement",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "UniversiteId",
                table: "Etablissement",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Etablissement",
                table: "Etablissement",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Etablissement_UniversiteId",
                table: "Etablissement",
                column: "UniversiteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Etablissement_Etablissement_UniversiteId",
                table: "Etablissement",
                column: "UniversiteId",
                principalTable: "Etablissement",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Filiere_Etablissement_EcolePriveId",
                table: "Filiere",
                column: "EcolePriveId",
                principalTable: "Etablissement",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Filiere_Etablissement_FaculteId",
                table: "Filiere",
                column: "FaculteId",
                principalTable: "Etablissement",
                principalColumn: "Id");
        }
    }
}
