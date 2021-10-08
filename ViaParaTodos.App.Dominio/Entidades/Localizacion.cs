namespace ViaParaTodos.App.Dominio.Entidades
{
    public class Localizacion
    {
       public int Id {set;get;} 
       public string Ciudad {set;get;}
       public string Zona {set;get;}
       public string Latitud {set;get;}
       public string Longitud {set;get;}
       public Accidente Accidente {set;get;}
       public int LocalizacionAccidenteId {set;get;}
    }
}