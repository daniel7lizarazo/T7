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
            //AddConductor();
            //AddAgentesTransito();
            //AddAccidente();
            //AddTablaVC();
            //AddVinculados();
            //AddLocalizacion();
            //UpdateConductor();
            //SearchConductor(1);
            //SearchConductorDocumento("963852714");
            //SearchVehiculo(1);
            //SearchAllConductores();
            ReportarAccidente(new DateTime (2024,09,13),"Pretty nasty accident", "Nasty as hell", "C65L25", "Sur", "XXX-999", "2531246", "123456");
        }
private static void ReportarAccidente(DateTime fecha, string descripcion, string gravedad, string agenteIdentificacion, string zona, string placa, string idconductor, string idvinculado)
{
    Accidente accidente= new Accidente
    {
        Fecha = fecha,
        Descripcion = descripcion,
        Gravedad = gravedad,
        AccidenteLocalizacionId = _repoLocalizacion.GetLocalizacionByZona(zona).Id,
        AccidenteAgentesTransitoId = _repoAgentesTransito.GetAgentesTransitoByIdentificacion(agenteIdentificacion).Id 
    };
    Accidente accidenteagregado = _repoAccidente.AddAccidente(accidente);

    TablaVC tablavc = new TablaVC
    {
        VehiculosTablaVCId = _repoVehiculos.GetVehiculosByPlaca(placa).Id,
        ConductoresTablaVCId = _repoConductores.GetConductorByDocumento(idconductor).Id,
        AccidenteTablaVCId = accidenteagregado.Id
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
                Nombres="Paco",
                Apellidos="Cheveroni",
                TipoDoc="CE",
                NumeroDoc="457895",
                VigenciaLicencia=new DateTime (2024,09,13),
                Direccion="Cl 2 N 1-17 Sur",
                NumeroTelefono="578963"
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
            Vehiculos vehiculo = _repoVehiculos.GetVehiculos(idVehiculo);
            Console.WriteLine(vehiculo.Placa+" "+vehiculo.Marca);
        }

        private static void AddAgentesTransito()
        {
            AgentesTransito agenteTransito = new AgentesTransito
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
            Accidente accidente = new Accidente
            {
                Fecha=new DateTime(2021,05,05),
                Descripcion="Pues se estrellaron pero no hubo nada de especial, una pierna partidita",
                Gravedad="No tan grave you know",
                AccidenteAgentesTransitoId=1,
                AccidenteLocalizacionId=1
            };
            var accidenteAdded = _repoAccidente.AddAccidente(accidente);
            Console.WriteLine("ID:"+accidenteAdded.Id);
        } 

        private static void AddTablaVC()
        {
            TablaVC tablaVC = new TablaVC
            {
                VehiculosTablaVCId=1,
                ConductoresTablaVCId=1,
                AccidenteTablaVCId=1
            };
            _repoTablaVC.AddTablaVC(tablaVC);
        } 

        private static void AddVinculados()
        {
            Vinculados vinculado = new Vinculados
            {
                Nombres="Alexander",
                Apellidos="Vargas",
                TipoDoc="CC",
                NumeroDoc="456123",
                Direccion="Cr 33 #9-75",
                NumeroTelefono="888888888",
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
