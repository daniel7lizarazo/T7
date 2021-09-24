using System;

namespace ViaParaTodos.App.Dominio.Entidades
{
    public class Conductores:Personas
    {
       public DateTime VigenciaLicencia {set;get;}
       public string Direccion {set;get;}
       public string NumeroTelefono {set;get;}
    }
}