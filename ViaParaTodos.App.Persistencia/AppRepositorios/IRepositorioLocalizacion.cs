using System.Collections.Generic;
using ViaParaTodos.App.Dominio.Entidades;
namespace ViaParaTodos.App.Persistencia.AppRepositorios
{
    public interface IRepositorioLocalizacion
    {
        IEnumerable<Localizacion> GetAllLocalizacion();
        Localizacion AddLocalizacion(Localizacion localizacion); 
        Localizacion UpdateLocalizacion(Localizacion localizacion);
        void DeleteLocalizacion (int idLocalizacion);
        Localizacion GetLocalizacion (int idLocalizacion);
         
    }
}