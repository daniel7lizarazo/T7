//using System.ComponentMode.DataAnnotations;
namespace ViaParaTodos.App.Dominio.Entidades
{
    public class TablaVC
    {
        public int Id {set;get;}
        public Vehiculos Vehiculos {set;get;}
        public int VehiculosId {set;get;}
        public Conductores Conductores  {set;get;}
        public int ConductoresId  {set;get;}
        public Accidente Accidente  {set; get;}
        public int AccidenteId  {set; get;}
    }
}