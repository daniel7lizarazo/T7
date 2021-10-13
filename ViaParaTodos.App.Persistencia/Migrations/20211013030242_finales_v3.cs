using Microsoft.EntityFrameworkCore.Migrations;

namespace ViaParaTodos.App.Persistencia.Migrations
{
    public partial class finales_v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TablaVA_Accidente_AccidenteId",
                table: "TablaVA");

            migrationBuilder.DropColumn(
                name: "AcidenteId",
                table: "TablaVA");

            migrationBuilder.AlterColumn<int>(
                name: "AccidenteId",
                table: "TablaVA",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TablaVA_Accidente_AccidenteId",
                table: "TablaVA",
                column: "AccidenteId",
                principalTable: "Accidente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TablaVA_Accidente_AccidenteId",
                table: "TablaVA");

            migrationBuilder.AlterColumn<int>(
                name: "AccidenteId",
                table: "TablaVA",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "AcidenteId",
                table: "TablaVA",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_TablaVA_Accidente_AccidenteId",
                table: "TablaVA",
                column: "AccidenteId",
                principalTable: "Accidente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
