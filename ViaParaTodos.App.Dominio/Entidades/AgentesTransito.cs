using System;
using System.Collections.Generic;

namespace ViaParaTodos.App.Dominio.Entidades
{
    public class AgentesTransito
    {
        public int Id {set;get;}
        public string Usuario {set;get;}
        public string Contrasena {set;get;}
        public string Identificacion {set;get;}
        public string Rango {set;get;}
        public IEnumerable<Accidente> Accidente {set;get;}
    }
}