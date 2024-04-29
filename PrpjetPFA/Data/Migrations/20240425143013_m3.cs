using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrpjetPFA.Data.Migrations
{
    /// <inheritdoc />
    public partial class m3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Etablissement",
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
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UniversiteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etablissement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Etablissement_Etablissement_UniversiteId",
                        column: x => x.UniversiteId,
                        principalTable: "Etablissement",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Filiere",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionFiliere = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContenuDuProgramme = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Debouche = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConditionDadmission = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cout = table.Column<double>(type: "float", nullable: false),
                    EcolePriveId = table.Column<int>(type: "int", nullable: true),
                    FaculteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filiere", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Filiere_Etablissement_EcolePriveId",
                        column: x => x.EcolePriveId,
                        principalTable: "Etablissement",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Filiere_Etablissement_FaculteId",
                        column: x => x.FaculteId,
                        principalTable: "Etablissement",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Etablissement_UniversiteId",
                table: "Etablissement",
                column: "UniversiteId");

            migrationBuilder.CreateIndex(
                name: "IX_Filiere_EcolePriveId",
                table: "Filiere",
                column: "EcolePriveId");

            migrationBuilder.CreateIndex(
                name: "IX_Filiere_FaculteId",
                table: "Filiere",
                column: "FaculteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Filiere");

            migrationBuilder.DropTable(
                name: "Etablissement");
        }
    }
}
