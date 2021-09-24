using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ViaParaTodos.App.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "documentos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tPropiedad = table.Column<bool>(type: "bit", nullable: false),
                    tMecanica = table.Column<bool>(type: "bit", nullable: false),
                    soat = table.Column<bool>(type: "bit", nullable: false),
                    planilla = table.Column<bool>(type: "bit", nullable: false),
                    tOficial = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_documentos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "localizacion",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    barrio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    latitud = table.Column<float>(type: "real", nullable: false),
                    longitus = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_localizacion", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "personas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tipoDoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NDoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    genero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Administrador_usuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Administrador_contrasena = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    usuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contrasena = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idAgente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rango = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vigenciaLicencia = table.Column<DateTime>(type: "datetime2", nullable: true),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nTelefono = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "vehiculos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    placa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    modelo = table.Column<int>(type: "int", nullable: false),
                    marca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    linea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    claseServicio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    documentosid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehiculos", x => x.id);
                    table.ForeignKey(
                        name: "FK_vehiculos_documentos_documentosid",
                        column: x => x.documentosid,
                        principalTable: "documentos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "accidente",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    hora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    propietariosid = table.Column<int>(type: "int", nullable: true),
                    conductoresid = table.Column<int>(type: "int", nullable: true),
                    agenteTransitoid = table.Column<int>(type: "int", nullable: true),
                    localizacionid = table.Column<int>(type: "int", nullable: true),
                    vehiculosid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accidente", x => x.id);
                    table.ForeignKey(
                        name: "FK_accidente_localizacion_localizacionid",
                        column: x => x.localizacionid,
                        principalTable: "localizacion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_accidente_personas_agenteTransitoid",
                        column: x => x.agenteTransitoid,
                        principalTable: "personas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_accidente_personas_conductoresid",
                        column: x => x.conductoresid,
                        principalTable: "personas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_accidente_personas_propietariosid",
                        column: x => x.propietariosid,
                        principalTable: "personas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_accidente_vehiculos_vehiculosid",
                        column: x => x.vehiculosid,
                        principalTable: "vehiculos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_accidente_agenteTransitoid",
                table: "accidente",
                column: "agenteTransitoid");

            migrationBuilder.CreateIndex(
                name: "IX_accidente_conductoresid",
                table: "accidente",
                column: "conductoresid");

            migrationBuilder.CreateIndex(
                name: "IX_accidente_localizacionid",
                table: "accidente",
                column: "localizacionid");

            migrationBuilder.CreateIndex(
                name: "IX_accidente_propietariosid",
                table: "accidente",
                column: "propietariosid");

            migrationBuilder.CreateIndex(
                name: "IX_accidente_vehiculosid",
                table: "accidente",
                column: "vehiculosid");

            migrationBuilder.CreateIndex(
                name: "IX_vehiculos_documentosid",
                table: "vehiculos",
                column: "documentosid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "accidente");

            migrationBuilder.DropTable(
                name: "localizacion");

            migrationBuilder.DropTable(
                name: "personas");

            migrationBuilder.DropTable(
                name: "vehiculos");

            migrationBuilder.DropTable(
                name: "documentos");
        }
    }
}
