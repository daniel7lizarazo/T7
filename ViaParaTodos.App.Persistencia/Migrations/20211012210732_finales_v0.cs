using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ViaParaTodos.App.Persistencia.Migrations
{
    public partial class finales_v0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AgentesTransito",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contrasena = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Identificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rango = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgentesTransito", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Localizacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Zona = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Latitud = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Longitud = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localizacion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Placa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modelo = table.Column<int>(type: "int", nullable: true),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Linea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Accidente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gravedad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccidenteLocalizacionId = table.Column<int>(type: "int", nullable: false),
                    AgenteIdId = table.Column<int>(type: "int", nullable: true),
                    AccidenteAgentesTransitoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accidente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accidente_AgentesTransito_AgenteIdId",
                        column: x => x.AgenteIdId,
                        principalTable: "AgentesTransito",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Accidente_Localizacion_AccidenteLocalizacionId",
                        column: x => x.AccidenteLocalizacionId,
                        principalTable: "Localizacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ciudadanos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoDoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroDoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroTelefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VigenciaLicencia = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Testigo = table.Column<bool>(type: "bit", nullable: true),
                    Afectado = table.Column<bool>(type: "bit", nullable: true),
                    AccidenteId = table.Column<int>(type: "int", nullable: true),
                    VinculadosAccidenteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudadanos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ciudadanos_Accidente_AccidenteId",
                        column: x => x.AccidenteId,
                        principalTable: "Accidente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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
                name: "IX_Accidente_AccidenteLocalizacionId",
                table: "Accidente",
                column: "AccidenteLocalizacionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Accidente_AgenteIdId",
                table: "Accidente",
                column: "AgenteIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Ciudadanos_AccidenteId",
                table: "Ciudadanos",
                column: "AccidenteId");

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

            migrationBuilder.DropTable(
                name: "Ciudadanos");

            migrationBuilder.DropTable(
                name: "Vehiculos");

            migrationBuilder.DropTable(
                name: "Accidente");

            migrationBuilder.DropTable(
                name: "AgentesTransito");

            migrationBuilder.DropTable(
                name: "Localizacion");
        }
    }
}
