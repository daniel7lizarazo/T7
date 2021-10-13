using System;
//using System.ComponentMode.DataAnnotations;
using System.Collections.Generic;

namespace ViaParaTodos.App.Dominio.Entidades
{
    public class Accidente
    {
        public int Id {set;get;}
        public DateTime? Fecha {set;get;}
        public string Descripcion {set;get;}
        public string Gravedad {set;get;}
        public Localizacion Localizacion {set;get;}
        public int LocalizacionId {set;get;}
        public AgentesTransito AgentesTransito {set;get;}
        public int AgentesTransitoId {set;get;}
        public IEnumerable<TablaVC> TablaVC {set;get;}
        public IEnumerable<TablaVA> TablaVA {set;get;}
    }
}