using Microsoft.EntityFrameworkCore.Migrations;

namespace ViaParaTodos.App.Persistencia.Migrations
{
    public partial class finales_v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accidente_AgentesTransito_AgenteIdId",
                table: "Accidente");

            migrationBuilder.DropTable(
                name: "AccidenteVinculados");

            migrationBuilder.RenameColumn(
                name: "AgenteIdId",
                table: "Accidente",
                newName: "AgenteId");

            migrationBuilder.RenameIndex(
                name: "IX_Accidente_AgenteIdId",
                table: "Accidente",
                newName: "IX_Accidente_AgenteId");

            migrationBuilder.CreateTable(
                name: "TablaVA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccidenteId = table.Column<int>(type: "int", nullable: true),
                    AcidenteId = table.Column<int>(type: "int", nullable: false),
                    VinculadosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablaVA", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TablaVA_Accidente_AccidenteId",
                        column: x => x.AccidenteId,
                        principalTable: "Accidente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TablaVA_Ciudadanos_VinculadosId",
                        column: x => x.VinculadosId,
                        principalTable: "Ciudadanos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TablaVA_AccidenteId",
                table: "TablaVA",
                column: "AccidenteId");

            migrationBuilder.CreateIndex(
                name: "IX_TablaVA_VinculadosId",
                table: "TablaVA",
                column: "VinculadosId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accidente_AgentesTransito_AgenteId",
                table: "Accidente",
                column: "AgenteId",
                principalTable: "AgentesTransito",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accidente_AgentesTransito_AgenteId",
                table: "Accidente");

            migrationBuilder.DropTable(
                name: "TablaVA");

            migrationBuilder.RenameColumn(
                name: "AgenteId",
                table: "Accidente",
                newName: "AgenteIdId");

            migrationBuilder.RenameIndex(
                name: "IX_Accidente_AgenteId",
                table: "Accidente",
                newName: "IX_Accidente_AgenteIdId");

            migrationBuilder.CreateTable(
                name: "AccidenteVinculados",
                columns: table => new
                {
                    AccidenteId = table.Column<int>(type: "int", nullable: false),
                    VinculadosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccidenteVinculados", x => new { x.AccidenteId, x.VinculadosId });
                    table.ForeignKey(
                        name: "FK_AccidenteVinculados_Accidente_AccidenteId",
                        column: x => x.AccidenteId,
                        principalTable: "Accidente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccidenteVinculados_Ciudadanos_VinculadosId",
                        column: x => x.VinculadosId,
                        principalTable: "Ciudadanos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccidenteVinculados_VinculadosId",
                table: "AccidenteVinculados",
                column: "VinculadosId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accidente_AgentesTransito_AgenteIdId",
                table: "Accidente",
                column: "AgenteIdId",
                principalTable: "AgentesTransito",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
