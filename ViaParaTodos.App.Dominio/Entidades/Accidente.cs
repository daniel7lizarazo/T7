using System;
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
        public int AccidenteAgentesTransitoId {set;get;}
        public List<TablaVC> TablaVC {set;get;}
        public List<Vinculados> Vinculados {set;get;}
    }
}