using System;

namespace ViaParaTodos.App.Dominio.Entidades
{
    public class Accidente
    {
       public int Id {set;get;}
       public DateTime Fecha {set;get;}
       public DateTime Hora {set;get;}
       public Propietarios Propietarios {set;get;}
       public Conductores Conductores {set;get;}
       public AgenteTransito AgenteTransito {set;get;}
       public Localizacion Localizacion {set;get;}
       public Vehiculos Vehiculos {set;get;}
    }
}