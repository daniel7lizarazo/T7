using System.Collections.Generic;
using System;

namespace ViaParaTodos.App.Dominio.Entidades
{
    public class Conductores:Ciudadanos
    {
        public DateTime VigenciaLicencia {set;get;}
        public TablaVC TablaVC {get;set;}
    }
}