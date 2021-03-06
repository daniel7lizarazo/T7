//using System.ComponentMode.DataAnnotations;
using System.Collections.Generic;
namespace ViaParaTodos.App.Dominio.Entidades
{
    public class Vehiculos
    {
        public int Id {set;get;}
        public string Placa {set;get;}
        public int? Modelo {set;get;}
        public string Marca {set;get;}
        public string Linea {set;get;}
        public string Color {set;get;}
        public IEnumerable<TablaVC> TablaVC {get;set;}
    }
}