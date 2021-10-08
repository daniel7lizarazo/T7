using Microsoft.EntityFrameworkCore.Migrations;

namespace ViaParaTodos.App.Persistencia.Migrations
{
    public partial class inicial_v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
