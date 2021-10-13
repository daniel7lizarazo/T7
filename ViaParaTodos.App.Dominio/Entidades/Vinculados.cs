//using System.ComponentMode.DataAnnotations;
using System.Collections.Generic;

namespace ViaParaTodos.App.Dominio.Entidades
{
    public class Vinculados : Ciudadanos
    {
        public bool Testigo {set;get;}
        public bool Afectado {set;get;}
        public IEnumerable<TablaVA> TablaVA {set;get;}

    }
}