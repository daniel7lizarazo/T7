namespace ViaParaTodos.App.Dominio.Entidades
{
    public class Vinculados : Ciudadanos
    {
        public bool Testigo {set;get;}
        public bool Afectado {set;get;}
        public Accidente Accidente {set;get;}
        public int VinculadosAccidenteId {set;get;}
    }
}