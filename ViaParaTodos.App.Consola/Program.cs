using System.Data.Common;
using ViaParaTodos.App.Dominio.Entidades;
using ViaParaTodos.App.Persistencia.AppRepositorios;
using System;

namespace ViaParaTodos.App.Consola
{
    class Program
    {
        private static IRepositorioConductores _repoConductores= new RepositorioConductores(new Persistencia.AppRepositorios.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! From Console Entity Framework Core");
            //AddConductor();
            SearchConductor(1);
        }
        private static void AddConductor()
        {
            var conductor = new Conductores{
                Nombres="Nicolas",
                Apellidos="Perez",
                TipoDoc="Cedula",
                NumeroDoc="2086568973",
                Genero="none",
                VigenciaLicencia=new DateTime (2022,01,01),
                Direccion="Calle 86 #5-63",
                NumeroTelefono="999999999"
            };
            _repoConductores.AddConductor(conductor);
        }
        private static void SearchConductor(int idConductor)        
        {
            var conductor = _repoConductores.GetConductor(idConductor);
            Console.WriteLine(conductor.Nombres+" "+conductor.Apellidos);
        }
    }
}
