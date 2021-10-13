using Microsoft.EntityFrameworkCore.Migrations;

namespace ViaParaTodos.App.Persistencia.Migrations
{
    public partial class finales_v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ciudadanos_Accidente_AccidenteId",
                table: "Ciudadanos");

            migrationBuilder.DropIndex(
                name: "IX_Ciudadanos_AccidenteId",
                table: "Ciudadanos");

            migrationBuilder.DropColumn(
                name: "AccidenteId",
                table: "Ciudadanos");

            migrationBuilder.DropColumn(
                name: "VinculadosAccidenteId",
                table: "Ciudadanos");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccidenteVinculados");

            migrationBuilder.AddColumn<int>(
                name: "AccidenteId",
                table: "Ciudadanos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VinculadosAccidenteId",
                table: "Ciudadanos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ciudadanos_AccidenteId",
                table: "Ciudadanos",
                column: "AccidenteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ciudadanos_Accidente_AccidenteId",
                table: "Ciudadanos",
                column: "AccidenteId",
                principalTable: "Accidente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
