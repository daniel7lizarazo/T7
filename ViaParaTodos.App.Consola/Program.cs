﻿using System.Data.Common;
using ViaParaTodos.App.Dominio.Entidades;
using ViaParaTodos.App.Persistencia.AppRepositorios;
using System;

namespace ViaParaTodos.App.Consola
{
    class Program
    {
        private static IRepositorioConductores _repoConductores= new RepositorioConductores(new Persistencia.AppRepositorios.AppContext());
        private static IRepositorioVehiculos _repoVehiculos = new RepositorioVehiculos(new Persistencia.AppRepositorios.AppContext());
        private static IRepositorioTablaVC _repoTablaVC = new RepositorioTablaVC(new Persistencia.AppRepositorios.AppContext());
        private static IRepositorioVinculados _repoVinculados = new RepositorioVinculados(new Persistencia.AppRepositorios.AppContext());
        private static IRepositorioLocalizacion _repoLocalizacion  = new RepositorioLocalizacion (new Persistencia.AppRepositorios.AppContext());
        private static IRepositorioAccidente _repoAccidente  = new RepositorioAccidente (new Persistencia.AppRepositorios.AppContext());
        private static IRepositorioAgentesTransito _repoAgentesTransito  = new RepositorioAgentesTransito (new Persistencia.AppRepositorios.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! From Console Entity Framework Core");
            //AddVehiculo();
            //AddConductor();
            //AddAgentesTransito();
            //AddAccidente();
            //AddTablaVC();
            //AddVinculados();
            //AddLocalizacion();
            //UpdateConductor();
            SearchConductor(1);
            SearchVehiculo(1);
        }
        private static void AddConductor()
        {
            var conductor = new Conductores
            {
                Nombres="Nicolas",
                Apellidos="Perez",
                TipoDoc="Cedula",
                NumeroDoc="2086568973",
                VigenciaLicencia=new DateTime (2022,01,01),
                Direccion="Calle 86 #5-63",
                NumeroTelefono="999999999"
            };
            _repoConductores.AddConductor(conductor);
        }
        private static void UpdateConductor()
        {
            var conductor = new Conductores
            {
                Id=1,
                Nombres="Nicolazol",
                Apellidos="Perezoniel",
                TipoDoc="Cedula",
                NumeroDoc="2086568973",
                VigenciaLicencia=new DateTime (2022,01,01),
                Direccion="Calle 86 #5-63",
                NumeroTelefono="999999999"
            };
            _repoConductores.UpdateConductor(conductor);
        }
        private static void SearchConductor(int idConductor)        
        {
            var conductor = _repoConductores.GetConductor(idConductor);
            Console.WriteLine(conductor.Nombres+" "+conductor.Apellidos);
        }
        private static void AddVehiculo()
        {
            var vehiculo = new Vehiculos
            {
                Placa="KKK999",
                Modelo=2019,
                Marca="Renoult",
                Linea="Sandero",
                Color="Azul asteroide"
            };
            _repoVehiculos.AddVehiculos(vehiculo);
        } 
        private static void SearchVehiculo(int idVehiculo)
        {
            var vehiculo = _repoVehiculos.GetVehiculos(idVehiculo);
            Console.WriteLine(vehiculo.Placa+" "+vehiculo.Marca);
        }
        private static void AddAgentesTransito()
        {
            var agenteTransito = new AgentesTransito
            {
                Usuario="El papucho",
                Contrasena="elaccidentado69",
                Identificacion="00110011",
                Rango="Generalisimo",
            };
            _repoAgentesTransito.AddAgentesTransito(agenteTransito);
        } 
        private static void AddAccidente()
        {
            var accidente = new Accidente
            {
                Fecha=new DateTime(2021,02,02),
                Descripcion="Moto carro, pum pum, crack crack",
                Gravedad="Moderada",
                AccidenteAgentesTransitoId=1
            };
            _repoAccidente.AddAccidente(accidente);
        } 
        private static void AddTablaVC()
        {
            var tablaVC = new TablaVC
            {
                VehiculosTablaVCId=1,
                ConductoresTablaVCId=1,
                AccidenteTablaVCId=1
            };
            _repoTablaVC.AddTablaVC(tablaVC);
        } 
        private static void AddVinculados()
        {
            var vinculado = new Vinculados
            {
                Nombres="Andrea",
                Apellidos="Becerra",
                TipoDoc="Pasaporte",
                NumeroDoc="987654321",
                Direccion="Carrera 45 #55-20",
                NumeroTelefono="333222111",
                Testigo=true,
                Afectado=false,
                VinculadosAccidenteId=1
            };
            _repoVinculados.AddVinculados(vinculado);
        } 
        private static void AddLocalizacion()
        {
            var localizacion = new Localizacion
            {
                Ciudad="Bucaramanga",
                Zona="AnilloVial",
                Latitud="203.6589.6633",
                Longitud="693.6489.4652",
                LocalizacionAccidenteId=1
            };
            _repoLocalizacion.AddLocalizacion(localizacion);
        } 
    }
}
