//using System.ComponentMode.DataAnnotations;
namespace ViaParaTodos.App.Dominio.Entidades
{
    public class TablaVA
    {
        public int Id {set;get;}
        public Accidente Accidente {set;get;}
        public int AccidenteId {set;get;}
        public Vinculados Vinculados {set;get;}
        public int VinculadosId {set;get;}
    }
}