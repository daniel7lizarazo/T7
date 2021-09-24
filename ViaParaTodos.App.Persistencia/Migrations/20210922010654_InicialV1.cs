using Microsoft.EntityFrameworkCore.Migrations;

namespace ViaParaTodos.App.Persistencia.Migrations
{
    public partial class InicialV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_accidente_localizacion_localizacionid",
                table: "accidente");

            migrationBuilder.DropForeignKey(
                name: "FK_accidente_personas_agenteTransitoid",
                table: "accidente");

            migrationBuilder.DropForeignKey(
                name: "FK_accidente_personas_conductoresid",
                table: "accidente");

            migrationBuilder.DropForeignKey(
                name: "FK_accidente_personas_propietariosid",
                table: "accidente");

            migrationBuilder.DropForeignKey(
                name: "FK_accidente_vehiculos_vehiculosid",
                table: "accidente");

            migrationBuilder.DropForeignKey(
                name: "FK_vehiculos_documentos_documentosid",
                table: "vehiculos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_vehiculos",
                table: "vehiculos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_personas",
                table: "personas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_localizacion",
                table: "localizacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_documentos",
                table: "documentos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_accidente",
                table: "accidente");

            migrationBuilder.RenameTable(
                name: "vehiculos",
                newName: "Vehiculos");

            migrationBuilder.RenameTable(
                name: "personas",
                newName: "Personas");

            migrationBuilder.RenameTable(
                name: "localizacion",
                newName: "Localizacion");

            migrationBuilder.RenameTable(
                name: "documentos",
                newName: "Documentos");

            migrationBuilder.RenameTable(
                name: "accidente",
                newName: "Accidente");

            migrationBuilder.RenameColumn(
                name: "tipo",
                table: "Vehiculos",
                newName: "Tipo");

            migrationBuilder.RenameColumn(
                name: "placa",
                table: "Vehiculos",
                newName: "Placa");

            migrationBuilder.RenameColumn(
                name: "modelo",
                table: "Vehiculos",
                newName: "Modelo");

            migrationBuilder.RenameColumn(
                name: "marca",
                table: "Vehiculos",
                newName: "Marca");

            migrationBuilder.RenameColumn(
                name: "linea",
                table: "Vehiculos",
                newName: "Linea");

            migrationBuilder.RenameColumn(
                name: "documentosid",
                table: "Vehiculos",
                newName: "DocumentosId");

            migrationBuilder.RenameColumn(
                name: "color",
                table: "Vehiculos",
                newName: "Color");

            migrationBuilder.RenameColumn(
                name: "claseServicio",
                table: "Vehiculos",
                newName: "ClaseServicio");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Vehiculos",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_vehiculos_documentosid",
                table: "Vehiculos",
                newName: "IX_Vehiculos_DocumentosId");

            migrationBuilder.RenameColumn(
                name: "vigenciaLicencia",
                table: "Personas",
                newName: "VigenciaLicencia");

            migrationBuilder.RenameColumn(
                name: "usuario",
                table: "Personas",
                newName: "Usuario");

            migrationBuilder.RenameColumn(
                name: "tipoDoc",
                table: "Personas",
                newName: "TipoDoc");

            migrationBuilder.RenameColumn(
                name: "rango",
                table: "Personas",
                newName: "Rango");

            migrationBuilder.RenameColumn(
                name: "nombres",
                table: "Personas",
                newName: "Nombres");

            migrationBuilder.RenameColumn(
                name: "idAgente",
                table: "Personas",
                newName: "IdAgente");

            migrationBuilder.RenameColumn(
                name: "genero",
                table: "Personas",
                newName: "Genero");

            migrationBuilder.RenameColumn(
                name: "direccion",
                table: "Personas",
                newName: "Direccion");

            migrationBuilder.RenameColumn(
                name: "contrasena",
                table: "Personas",
                newName: "Contrasena");

            migrationBuilder.RenameColumn(
                name: "apellidos",
                table: "Personas",
                newName: "Apellidos");

            migrationBuilder.RenameColumn(
                name: "Administrador_usuario",
                table: "Personas",
                newName: "Administrador_Usuario");

            migrationBuilder.RenameColumn(
                name: "Administrador_contrasena",
                table: "Personas",
                newName: "Administrador_Contrasena");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Personas",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "nTelefono",
                table: "Personas",
                newName: "NumeroTelefono");

            migrationBuilder.RenameColumn(
                name: "NDoc",
                table: "Personas",
                newName: "NumeroDoc");

            migrationBuilder.RenameColumn(
                name: "longitus",
                table: "Localizacion",
                newName: "Longitus");

            migrationBuilder.RenameColumn(
                name: "latitud",
                table: "Localizacion",
                newName: "Latitud");

            migrationBuilder.RenameColumn(
                name: "ciudad",
                table: "Localizacion",
                newName: "Ciudad");

            migrationBuilder.RenameColumn(
                name: "barrio",
                table: "Localizacion",
                newName: "Barrio");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Localizacion",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "soat",
                table: "Documentos",
                newName: "SOAT");

            migrationBuilder.RenameColumn(
                name: "planilla",
                table: "Documentos",
                newName: "Planilla");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Documentos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "tPropiedad",
                table: "Documentos",
                newName: "TarjetaPropiedad");

            migrationBuilder.RenameColumn(
                name: "tOficial",
                table: "Documentos",
                newName: "TarjetaOficial");

            migrationBuilder.RenameColumn(
                name: "tMecanica",
                table: "Documentos",
                newName: "TarjetaMecanica");

            migrationBuilder.RenameColumn(
                name: "vehiculosid",
                table: "Accidente",
                newName: "VehiculosId");

            migrationBuilder.RenameColumn(
                name: "propietariosid",
                table: "Accidente",
                newName: "PropietariosId");

            migrationBuilder.RenameColumn(
                name: "localizacionid",
                table: "Accidente",
                newName: "LocalizacionId");

            migrationBuilder.RenameColumn(
                name: "hora",
                table: "Accidente",
                newName: "Hora");

            migrationBuilder.RenameColumn(
                name: "fecha",
                table: "Accidente",
                newName: "Fecha");

            migrationBuilder.RenameColumn(
                name: "conductoresid",
                table: "Accidente",
                newName: "ConductoresId");

            migrationBuilder.RenameColumn(
                name: "agenteTransitoid",
                table: "Accidente",
                newName: "AgenteTransitoId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Accidente",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_accidente_vehiculosid",
                table: "Accidente",
                newName: "IX_Accidente_VehiculosId");

            migrationBuilder.RenameIndex(
                name: "IX_accidente_propietariosid",
                table: "Accidente",
                newName: "IX_Accidente_PropietariosId");

            migrationBuilder.RenameIndex(
                name: "IX_accidente_localizacionid",
                table: "Accidente",
                newName: "IX_Accidente_LocalizacionId");

            migrationBuilder.RenameIndex(
                name: "IX_accidente_conductoresid",
                table: "Accidente",
                newName: "IX_Accidente_ConductoresId");

            migrationBuilder.RenameIndex(
                name: "IX_accidente_agenteTransitoid",
                table: "Accidente",
                newName: "IX_Accidente_AgenteTransitoId");

            migrationBuilder.AddColumn<int>(
                name: "ConductoresId",
                table: "Vehiculos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PropietariosId",
                table: "Vehiculos",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehiculos",
                table: "Vehiculos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Personas",
                table: "Personas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Localizacion",
                table: "Localizacion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Documentos",
                table: "Documentos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Accidente",
                table: "Accidente",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_ConductoresId",
                table: "Vehiculos",
                column: "ConductoresId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_PropietariosId",
                table: "Vehiculos",
                column: "PropietariosId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accidente_Localizacion_LocalizacionId",
                table: "Accidente",
                column: "LocalizacionId",
                principalTable: "Localizacion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Accidente_Personas_AgenteTransitoId",
                table: "Accidente",
                column: "AgenteTransitoId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Accidente_Personas_ConductoresId",
                table: "Accidente",
                column: "ConductoresId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Accidente_Personas_PropietariosId",
                table: "Accidente",
                column: "PropietariosId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Accidente_Vehiculos_VehiculosId",
                table: "Accidente",
                column: "VehiculosId",
                principalTable: "Vehiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Documentos_DocumentosId",
                table: "Vehiculos",
                column: "DocumentosId",
                principalTable: "Documentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Personas_ConductoresId",
                table: "Vehiculos",
                column: "ConductoresId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Personas_PropietariosId",
                table: "Vehiculos",
                column: "PropietariosId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accidente_Localizacion_LocalizacionId",
                table: "Accidente");

            migrationBuilder.DropForeignKey(
                name: "FK_Accidente_Personas_AgenteTransitoId",
                table: "Accidente");

            migrationBuilder.DropForeignKey(
                name: "FK_Accidente_Personas_ConductoresId",
                table: "Accidente");

            migrationBuilder.DropForeignKey(
                name: "FK_Accidente_Personas_PropietariosId",
                table: "Accidente");

            migrationBuilder.DropForeignKey(
                name: "FK_Accidente_Vehiculos_VehiculosId",
                table: "Accidente");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Documentos_DocumentosId",
                table: "Vehiculos");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Personas_ConductoresId",
                table: "Vehiculos");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Personas_PropietariosId",
                table: "Vehiculos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehiculos",
                table: "Vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculos_ConductoresId",
                table: "Vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculos_PropietariosId",
                table: "Vehiculos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Personas",
                table: "Personas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Localizacion",
                table: "Localizacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Documentos",
                table: "Documentos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Accidente",
                table: "Accidente");

            migrationBuilder.DropColumn(
                name: "ConductoresId",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "PropietariosId",
                table: "Vehiculos");

            migrationBuilder.RenameTable(
                name: "Vehiculos",
                newName: "vehiculos");

            migrationBuilder.RenameTable(
                name: "Personas",
                newName: "personas");

            migrationBuilder.RenameTable(
                name: "Localizacion",
                newName: "localizacion");

            migrationBuilder.RenameTable(
                name: "Documentos",
                newName: "documentos");

            migrationBuilder.RenameTable(
                name: "Accidente",
                newName: "accidente");

            migrationBuilder.RenameColumn(
                name: "Tipo",
                table: "vehiculos",
                newName: "tipo");

            migrationBuilder.RenameColumn(
                name: "Placa",
                table: "vehiculos",
                newName: "placa");

            migrationBuilder.RenameColumn(
                name: "Modelo",
                table: "vehiculos",
                newName: "modelo");

            migrationBuilder.RenameColumn(
                name: "Marca",
                table: "vehiculos",
                newName: "marca");

            migrationBuilder.RenameColumn(
                name: "Linea",
                table: "vehiculos",
                newName: "linea");

            migrationBuilder.RenameColumn(
                name: "DocumentosId",
                table: "vehiculos",
                newName: "documentosid");

            migrationBuilder.RenameColumn(
                name: "Color",
                table: "vehiculos",
                newName: "color");

            migrationBuilder.RenameColumn(
                name: "ClaseServicio",
                table: "vehiculos",
                newName: "claseServicio");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "vehiculos",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Vehiculos_DocumentosId",
                table: "vehiculos",
                newName: "IX_vehiculos_documentosid");

            migrationBuilder.RenameColumn(
                name: "VigenciaLicencia",
                table: "personas",
                newName: "vigenciaLicencia");

            migrationBuilder.RenameColumn(
                name: "Usuario",
                table: "personas",
                newName: "usuario");

            migrationBuilder.RenameColumn(
                name: "TipoDoc",
                table: "personas",
                newName: "tipoDoc");

            migrationBuilder.RenameColumn(
                name: "Rango",
                table: "personas",
                newName: "rango");

            migrationBuilder.RenameColumn(
                name: "Nombres",
                table: "personas",
                newName: "nombres");

            migrationBuilder.RenameColumn(
                name: "IdAgente",
                table: "personas",
                newName: "idAgente");

            migrationBuilder.RenameColumn(
                name: "Genero",
                table: "personas",
                newName: "genero");

            migrationBuilder.RenameColumn(
                name: "Direccion",
                table: "personas",
                newName: "direccion");

            migrationBuilder.RenameColumn(
                name: "Contrasena",
                table: "personas",
                newName: "contrasena");

            migrationBuilder.RenameColumn(
                name: "Apellidos",
                table: "personas",
                newName: "apellidos");

            migrationBuilder.RenameColumn(
                name: "Administrador_Usuario",
                table: "personas",
                newName: "Administrador_usuario");

            migrationBuilder.RenameColumn(
                name: "Administrador_Contrasena",
                table: "personas",
                newName: "Administrador_contrasena");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "personas",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "NumeroTelefono",
                table: "personas",
                newName: "nTelefono");

            migrationBuilder.RenameColumn(
                name: "NumeroDoc",
                table: "personas",
                newName: "NDoc");

            migrationBuilder.RenameColumn(
                name: "Longitus",
                table: "localizacion",
                newName: "longitus");

            migrationBuilder.RenameColumn(
                name: "Latitud",
                table: "localizacion",
                newName: "latitud");

            migrationBuilder.RenameColumn(
                name: "Ciudad",
                table: "localizacion",
                newName: "ciudad");

            migrationBuilder.RenameColumn(
                name: "Barrio",
                table: "localizacion",
                newName: "barrio");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "localizacion",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "SOAT",
                table: "documentos",
                newName: "soat");

            migrationBuilder.RenameColumn(
                name: "Planilla",
                table: "documentos",
                newName: "planilla");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "documentos",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "TarjetaPropiedad",
                table: "documentos",
                newName: "tPropiedad");

            migrationBuilder.RenameColumn(
                name: "TarjetaOficial",
                table: "documentos",
                newName: "tOficial");

            migrationBuilder.RenameColumn(
                name: "TarjetaMecanica",
                table: "documentos",
                newName: "tMecanica");

            migrationBuilder.RenameColumn(
                name: "VehiculosId",
                table: "accidente",
                newName: "vehiculosid");

            migrationBuilder.RenameColumn(
                name: "PropietariosId",
                table: "accidente",
                newName: "propietariosid");

            migrationBuilder.RenameColumn(
                name: "LocalizacionId",
                table: "accidente",
                newName: "localizacionid");

            migrationBuilder.RenameColumn(
                name: "Hora",
                table: "accidente",
                newName: "hora");

            migrationBuilder.RenameColumn(
                name: "Fecha",
                table: "accidente",
                newName: "fecha");

            migrationBuilder.RenameColumn(
                name: "ConductoresId",
                table: "accidente",
                newName: "conductoresid");

            migrationBuilder.RenameColumn(
                name: "AgenteTransitoId",
                table: "accidente",
                newName: "agenteTransitoid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "accidente",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Accidente_VehiculosId",
                table: "accidente",
                newName: "IX_accidente_vehiculosid");

            migrationBuilder.RenameIndex(
                name: "IX_Accidente_PropietariosId",
                table: "accidente",
                newName: "IX_accidente_propietariosid");

            migrationBuilder.RenameIndex(
                name: "IX_Accidente_LocalizacionId",
                table: "accidente",
                newName: "IX_accidente_localizacionid");

            migrationBuilder.RenameIndex(
                name: "IX_Accidente_ConductoresId",
                table: "accidente",
                newName: "IX_accidente_conductoresid");

            migrationBuilder.RenameIndex(
                name: "IX_Accidente_AgenteTransitoId",
                table: "accidente",
                newName: "IX_accidente_agenteTransitoid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_vehiculos",
                table: "vehiculos",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_personas",
                table: "personas",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_localizacion",
                table: "localizacion",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_documentos",
                table: "documentos",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_accidente",
                table: "accidente",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_accidente_localizacion_localizacionid",
                table: "accidente",
                column: "localizacionid",
                principalTable: "localizacion",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_accidente_personas_agenteTransitoid",
                table: "accidente",
                column: "agenteTransitoid",
                principalTable: "personas",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_accidente_personas_conductoresid",
                table: "accidente",
                column: "conductoresid",
                principalTable: "personas",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_accidente_personas_propietariosid",
                table: "accidente",
                column: "propietariosid",
                principalTable: "personas",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_accidente_vehiculos_vehiculosid",
                table: "accidente",
                column: "vehiculosid",
                principalTable: "vehiculos",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_vehiculos_documentos_documentosid",
                table: "vehiculos",
                column: "documentosid",
                principalTable: "documentos",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
