//using System.ComponentMode.DataAnnotations;
using System.Collections.Generic;
namespace ViaParaTodos.App.Dominio.Entidades
{
    public class Localizacion
    {
       public int Id {set;get;} 
       public string Zona {set;get;}
       public string Latitud {set;get;}
       public string Longitud {set;get;}
       public IEnumerable<Accidente> Accidente {set;get;}
    }
}