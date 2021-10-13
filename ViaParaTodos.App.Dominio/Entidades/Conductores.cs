using System.Collections.Generic;
//using System.ComponentMode.DataAnnotations;
using System;

namespace ViaParaTodos.App.Dominio.Entidades
{
    public class Conductores:Ciudadanos
    {
        public DateTime VigenciaLicencia {set;get;}
        public IEnumerable<TablaVC> TablaVC {get;set;}
    }
}