using Microsoft.EntityFrameworkCore.Migrations;

namespace ViaParaTodos.App.Persistencia.Migrations
{
    public partial class inicial_v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TablaVCP");

            migrationBuilder.DropColumn(
                name: "Conductor",
                table: "Ciudadanos");

            migrationBuilder.CreateTable(
                name: "TablaVC",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehiculosTablaVCId = table.Column<int>(type: "int", nullable: false),
                    ConductoresTablaVCId = table.Column<int>(type: "int", nullable: false),
                    AccidenteId = table.Column<int>(type: "int", nullable: true),
                    AccidenteTablaVCId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablaVC", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TablaVC_Accidente_AccidenteId",
                        column: x => x.AccidenteId,
                        principalTable: "Accidente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TablaVC_Ciudadanos_ConductoresTablaVCId",
                        column: x => x.ConductoresTablaVCId,
                        principalTable: "Ciudadanos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TablaVC_Vehiculos_VehiculosTablaVCId",
                        column: x => x.VehiculosTablaVCId,
                        principalTable: "Vehiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TablaVC_AccidenteId",
                table: "TablaVC",
                column: "AccidenteId");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TablaVC");

            migrationBuilder.AddColumn<bool>(
                name: "Conductor",
                table: "Ciudadanos",
                type: "bit",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TablaVCP",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConductoresTablaVCPId = table.Column<int>(type: "int", nullable: false),
                    VehiculosTablaVCPId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablaVCP", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TablaVCP_Ciudadanos_ConductoresTablaVCPId",
                        column: x => x.ConductoresTablaVCPId,
                        principalTable: "Ciudadanos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TablaVCP_Vehiculos_VehiculosTablaVCPId",
                        column: x => x.VehiculosTablaVCPId,
                        principalTable: "Vehiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TablaVCP_ConductoresTablaVCPId",
                table: "TablaVCP",
                column: "ConductoresTablaVCPId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TablaVCP_VehiculosTablaVCPId",
                table: "TablaVCP",
                column: "VehiculosTablaVCPId",
                unique: true);
        }
    }
}
