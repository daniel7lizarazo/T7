using Microsoft.EntityFrameworkCore.Migrations;

namespace ViaParaTodos.App.Persistencia.Migrations
{
    public partial class finales_v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accidente_AgentesTransito_AgenteId",
                table: "Accidente");

            migrationBuilder.DropForeignKey(
                name: "FK_Accidente_Localizacion_AccidenteLocalizacionId",
                table: "Accidente");

            migrationBuilder.DropForeignKey(
                name: "FK_TablaVC_Accidente_AccidenteId",
                table: "TablaVC");

            migrationBuilder.DropForeignKey(
                name: "FK_TablaVC_Ciudadanos_ConductoresTablaVCId",
                table: "TablaVC");

            migrationBuilder.DropForeignKey(
                name: "FK_TablaVC_Vehiculos_VehiculosTablaVCId",
                table: "TablaVC");

            migrationBuilder.DropIndex(
                name: "IX_TablaVC_ConductoresTablaVCId",
                table: "TablaVC");

            migrationBuilder.DropIndex(
                name: "IX_TablaVC_VehiculosTablaVCId",
                table: "TablaVC");

            migrationBuilder.DropIndex(
                name: "IX_Accidente_AccidenteLocalizacionId",
                table: "Accidente");

            migrationBuilder.DropIndex(
                name: "IX_Accidente_AgenteId",
                table: "Accidente");

            migrationBuilder.DropColumn(
                name: "AccidenteTablaVCId",
                table: "TablaVC");

            migrationBuilder.DropColumn(
                name: "AgenteId",
                table: "Accidente");

            migrationBuilder.RenameColumn(
                name: "VehiculosTablaVCId",
                table: "TablaVC",
                newName: "VehiculosId");

            migrationBuilder.RenameColumn(
                name: "ConductoresTablaVCId",
                table: "TablaVC",
                newName: "ConductoresId");

            migrationBuilder.RenameColumn(
                name: "AccidenteLocalizacionId",
                table: "Accidente",
                newName: "LocalizacionId");

            migrationBuilder.RenameColumn(
                name: "AccidenteAgentesTransitoId",
                table: "Accidente",
                newName: "AgentesTransitoId");

            migrationBuilder.AlterColumn<int>(
                name: "AccidenteId",
                table: "TablaVC",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TablaVC_ConductoresId",
                table: "TablaVC",
                column: "ConductoresId");

            migrationBuilder.CreateIndex(
                name: "IX_TablaVC_VehiculosId",
                table: "TablaVC",
                column: "VehiculosId");

            migrationBuilder.CreateIndex(
                name: "IX_Accidente_AgentesTransitoId",
                table: "Accidente",
                column: "AgentesTransitoId");

            migrationBuilder.CreateIndex(
                name: "IX_Accidente_LocalizacionId",
                table: "Accidente",
                column: "LocalizacionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accidente_AgentesTransito_AgentesTransitoId",
                table: "Accidente",
                column: "AgentesTransitoId",
                principalTable: "AgentesTransito",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Accidente_Localizacion_LocalizacionId",
                table: "Accidente",
                column: "LocalizacionId",
                principalTable: "Localizacion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TablaVC_Accidente_AccidenteId",
                table: "TablaVC",
                column: "AccidenteId",
                principalTable: "Accidente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TablaVC_Ciudadanos_ConductoresId",
                table: "TablaVC",
                column: "ConductoresId",
                principalTable: "Ciudadanos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TablaVC_Vehiculos_VehiculosId",
                table: "TablaVC",
                column: "VehiculosId",
                principalTable: "Vehiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accidente_AgentesTransito_AgentesTransitoId",
                table: "Accidente");

            migrationBuilder.DropForeignKey(
                name: "FK_Accidente_Localizacion_LocalizacionId",
                table: "Accidente");

            migrationBuilder.DropForeignKey(
                name: "FK_TablaVC_Accidente_AccidenteId",
                table: "TablaVC");

            migrationBuilder.DropForeignKey(
                name: "FK_TablaVC_Ciudadanos_ConductoresId",
                table: "TablaVC");

            migrationBuilder.DropForeignKey(
                name: "FK_TablaVC_Vehiculos_VehiculosId",
                table: "TablaVC");

            migrationBuilder.DropIndex(
                name: "IX_TablaVC_ConductoresId",
                table: "TablaVC");

            migrationBuilder.DropIndex(
                name: "IX_TablaVC_VehiculosId",
                table: "TablaVC");

            migrationBuilder.DropIndex(
                name: "IX_Accidente_AgentesTransitoId",
                table: "Accidente");

            migrationBuilder.DropIndex(
                name: "IX_Accidente_LocalizacionId",
                table: "Accidente");

            migrationBuilder.RenameColumn(
                name: "VehiculosId",
                table: "TablaVC",
                newName: "VehiculosTablaVCId");

            migrationBuilder.RenameColumn(
                name: "ConductoresId",
                table: "TablaVC",
                newName: "ConductoresTablaVCId");

            migrationBuilder.RenameColumn(
                name: "LocalizacionId",
                table: "Accidente",
                newName: "AccidenteLocalizacionId");

            migrationBuilder.RenameColumn(
                name: "AgentesTransitoId",
                table: "Accidente",
                newName: "AccidenteAgentesTransitoId");

            migrationBuilder.AlterColumn<int>(
                name: "AccidenteId",
                table: "TablaVC",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "AccidenteTablaVCId",
                table: "TablaVC",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AgenteId",
                table: "Accidente",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TablaVC_ConductoresTablaVCId",
                table: "TablaVC",
                column: "ConductoresTablaVCId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TablaVC_VehiculosTablaVCId",
                table: "TablaVC",
                column: "VehiculosTablaVCId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Accidente_AccidenteLocalizacionId",
                table: "Accidente",
                column: "AccidenteLocalizacionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Accidente_AgenteId",
                table: "Accidente",
                column: "AgenteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accidente_AgentesTransito_AgenteId",
                table: "Accidente",
                column: "AgenteId",
                principalTable: "AgentesTransito",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Accidente_Localizacion_AccidenteLocalizacionId",
                table: "Accidente",
                column: "AccidenteLocalizacionId",
                principalTable: "Localizacion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TablaVC_Accidente_AccidenteId",
                table: "TablaVC",
                column: "AccidenteId",
                principalTable: "Accidente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TablaVC_Ciudadanos_ConductoresTablaVCId",
                table: "TablaVC",
                column: "ConductoresTablaVCId",
                principalTable: "Ciudadanos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TablaVC_Vehiculos_VehiculosTablaVCId",
                table: "TablaVC",
                column: "VehiculosTablaVCId",
                principalTable: "Vehiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
