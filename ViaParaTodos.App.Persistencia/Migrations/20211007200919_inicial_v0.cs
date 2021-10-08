using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ViaParaTodos.App.Persistencia.Migrations
{
    public partial class inicial_v0 : Migration
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
                    Conductor = table.Column<bool>(type: "bit", nullable: true),
                    Testigo = table.Column<bool>(type: "bit", nullable: true),
                    Afectado = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudadanos", x => x.Id);
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
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gravedad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentesTransitoId = table.Column<int>(type: "int", nullable: true),
                    AccidenteAgentesTransitoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accidente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accidente_AgentesTransito_AgentesTransitoId",
                        column: x => x.AgentesTransitoId,
                        principalTable: "AgentesTransito",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TablaVCP",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehiculosTablaVCPId = table.Column<int>(type: "int", nullable: false),
                    ConductoresTablaVCPId = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "Localizacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zona = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Latitud = table.Column<float>(type: "real", nullable: false),
                    Longitud = table.Column<float>(type: "real", nullable: false),
                    LocalizacionAccidenteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localizacion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Localizacion_Accidente_LocalizacionAccidenteId",
                        column: x => x.LocalizacionAccidenteId,
                        principalTable: "Accidente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accidente_AgentesTransitoId",
                table: "Accidente",
                column: "AgentesTransitoId");

            migrationBuilder.CreateIndex(
                name: "IX_Localizacion_LocalizacionAccidenteId",
                table: "Localizacion",
                column: "LocalizacionAccidenteId",
                unique: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Localizacion");

            migrationBuilder.DropTable(
                name: "TablaVCP");

            migrationBuilder.DropTable(
                name: "Accidente");

            migrationBuilder.DropTable(
                name: "Ciudadanos");

            migrationBuilder.DropTable(
                name: "Vehiculos");

            migrationBuilder.DropTable(
                name: "AgentesTransito");
        }
    }
}
