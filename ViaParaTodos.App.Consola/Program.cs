using System.Data.Common;
using ViaParaTodos.App.Dominio.Entidades;
using ViaParaTodos.App.Persistencia.AppRepositorios;
using System;
using System.Collections.Generic;

namespace ViaParaTodos.App.Consola
{
    class Program
    {
        private static IRepositorioConductores _repoConductores= new RepositorioConductores(new Persistencia.AppRepositorios.AppContext());
        private static IRepositorioVehiculos _repoVehiculos = new RepositorioVehiculos(new Persistencia.AppRepositorios.AppContext());
        private static IRepositorioTablaVC _repoTablaVC = new RepositorioTablaVC(new Persistencia.AppRepositorios.AppContext());
        private static IRepositorioTablaVA _repoTablaVA = new RepositorioTablaVA(new Persistencia.AppRepositorios.AppContext());
        private static IRepositorioVinculados _repoVinculados = new RepositorioVinculados(new Persistencia.AppRepositorios.AppContext());
        private static IRepositorioLocalizacion _repoLocalizacion  = new RepositorioLocalizacion (new Persistencia.AppRepositorios.AppContext());
        private static IRepositorioAccidente _repoAccidente  = new RepositorioAccidente (new Persistencia.AppRepositorios.AppContext());
        private static IRepositorioAgentesTransito _repoAgentesTransito  = new RepositorioAgentesTransito (new Persistencia.AppRepositorios.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! From Console Entity Framework Core");

            //AddVehiculo();
            //AddVinculados();
            //AddConductor();
            //AddAgentesTransito();
            //AddLocalizacion(); 
            //AddAccidente();
            //AddTablaVC();
            //AddTablaVA();

            //UpdateConductor();
            //SearchConductor(1);
            //SearchConductorDocumento("963852714");
            //SearchVehiculo(1);
            //SearchAllConductores();

            //AddAgentesTransito();

            //Para que la función que reporta un accidente funcione debe llenar la información necesaria, esta se encuentra
            //En la siguiente función, fecha, descripción, gravedad ... en la linea 41 está la función que estará llamando.
            //Tenga en cuenta que el accidente se crea de cero pero se relaciona con datos ya existentes en la base
            // es decir debe incluir datos de placa, documentos y zona, de elementos previamente creados.

            ReportarAccidente(new DateTime (2021,09,13),"Hubo muchos muertos", "Terrible", "B4S58", "Norte", "TTT-111", "5302456", "456123");
        }
            private static void ReportarAccidente(DateTime fecha, string descripcion, string gravedad, string agenteIdentificacion, string zona, string placa, string idconductor, string idvinculado)
            {
                Accidente accidente= new Accidente
                {
                    Fecha = fecha,
                    Descripcion = descripcion,
                    Gravedad = gravedad,
                    LocalizacionId = _repoLocalizacion.GetLocalizacionByZona(zona).Id,
                    AgentesTransitoId = _repoAgentesTransito.GetAgentesTransitoByIdentificacion(agenteIdentificacion).Id
                };
                Accidente accidenteagregado = _repoAccidente.AddAccidente(accidente);

                TablaVC tablavc = new TablaVC
                {
                    VehiculosId = _repoVehiculos.GetVehiculosByPlaca(placa).Id,
                    ConductoresId = _repoConductores.GetConductorByDocumento(idconductor).Id,
                    AccidenteId = accidenteagregado.Id
                };
                _repoTablaVC.AddTablaVC(tablavc);

                TablaVA tablava = new TablaVA
                {
                    VinculadosId = _repoVinculados.GetVinculadosByDocumento(idvinculado).Id,
                    AccidenteId = accidenteagregado.Id
                };
                _repoTablaVA.AddTablaVA(tablava);
            }




        private static void AddConductor()
        {
            Conductores conductor = new Conductores
            {
                Nombres="Perri",
                Apellidos="Ornitorrinco",
                TipoDoc="CE",
                NumeroDoc="007",
                VigenciaLicencia=new DateTime (2034,09,13),
                Direccion="Cl 0 N 0-07 Sur",
                NumeroTelefono="070707"
            };
            _repoConductores.AddConductor(conductor);
        }

        private static void UpdateConductor()
        {
            Conductores conductor = new Conductores
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
            Conductores conductor = _repoConductores.GetConductor(idConductor);
            Console.WriteLine(conductor.Nombres+" "+conductor.Apellidos);
        }

        private static void SearchConductorDocumento(string ConductorDocumento)        
        {
            Conductores conductor = _repoConductores.GetConductorByDocumento(ConductorDocumento);
            Console.WriteLine(conductor.Nombres+" "+conductor.Apellidos);
        }

        private static void SearchAllConductores()        
        {
            IEnumerable<Conductores> AllConductores = _repoConductores.GetAllConductores();

            foreach (Conductores conductor in AllConductores)
            {
                Console.WriteLine(conductor.Nombres+" "+conductor.Apellidos);
            }
        }

        private static void AddVehiculo()
        {
            Vehiculos vehiculo = new Vehiculos
            {
                Placa="OOO-777",
                Modelo=2019,
                Marca="Renoult",
                Linea="Clio",
                Color="Magenta"
            };
            _repoVehiculos.AddVehiculos(vehiculo);
        } 

        private static void SearchVehiculo(int idVehiculo)
        {
            Vehiculos vehiculo = _repoVehiculos.GetVehiculos(idVehiculo);
            Console.WriteLine(vehiculo.Placa+" "+vehiculo.Marca);
        }

        private static void AddAgentesTransito()
        {
            AgentesTransito agenteTransito = new AgentesTransito
            {
                Usuario="Francisco",
                Contrasena="Elfranci",
                Identificacion="C98JK",
                Rango="Generalisimo",
            };
            _repoAgentesTransito.AddAgentesTransito(agenteTransito);
        } 

        private static void AddAccidente()
        {
            Accidente accidente = new Accidente
            {
                Fecha=new DateTime(2021,05,05),
                Descripcion="Pues se estrellaron pero no hubo nada de especial, una pierna partidita",
                Gravedad="No tan grave you know",
                AgentesTransitoId=1,
                LocalizacionId=1
            };
            var accidenteAdded = _repoAccidente.AddAccidente(accidente);
            Console.WriteLine("ID:"+accidenteAdded.Id);
        } 

        private static void AddTablaVC()
        {
            TablaVC tablaVC = new TablaVC
            {
                VehiculosId=1,
                ConductoresId=1,
                AccidenteId=1
            };
            _repoTablaVC.AddTablaVC(tablaVC);
        } 

        private static void AddVinculados()
        {
            Vinculados vinculado = new Vinculados
            {
                Nombres="Pepito",
                Apellidos="Perez",
                TipoDoc="CC",
                NumeroDoc="000000",
                Direccion="Cr 0 #9-75",
                NumeroTelefono="01010101",
                Testigo=false,
                Afectado=true,
            };
            _repoVinculados.AddVinculados(vinculado);
        } 

        private static void AddLocalizacion()
        {
            Localizacion localizacion = new Localizacion
            {
                Zona="AnilloVial",
                Latitud="203.6589.6633",
                Longitud="693.6489.4652",
            };
            _repoLocalizacion.AddLocalizacion(localizacion);
        } 
    }
}
