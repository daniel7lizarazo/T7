using System.Linq;
using System.Collections.Generic;
using ViaParaTodos.App.Dominio.Entidades;
namespace ViaParaTodos.App.Persistencia.AppRepositorios
{
    public class RepositorioLocalizacion : IRepositorioLocalizacion
    {
         /// <summary>
        /// Referencia al contexto de Conductores
        /// </summary>
        private readonly AppContext _appContext;
        /// <summary>
        /// Metodo Constructor Utiliza 
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>//
        public RepositorioLocalizacion (AppContext appContext)
        {
            _appContext=appContext;
        }
       Localizacion IRepositorioLocalizacion.AddLocalizacion(Localizacion localizacion)
        {
           var localizacionAdicionado= _appContext.Localizacion.Add(localizacion); 
           _appContext.SaveChanges();
           return localizacionAdicionado.Entity;
        }

        void IRepositorioLocalizacion.DeleteLocalizacion(int idLocalizacion)
        {
            var localizacionEncontrado = _appContext.Localizacion.FirstOrDefault(l => l.Id == idLocalizacion);
            if(localizacionEncontrado==null)
                return;
            _appContext.Localizacion.Remove(localizacionEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Localizacion> IRepositorioLocalizacion.GetAllLocalizacion()
        {
            return _appContext.Localizacion;
        }

        Localizacion IRepositorioLocalizacion.GetLocalizacion(int idLocalizacion)
        {
            return _appContext.Localizacion.FirstOrDefault(l => l.Id == idLocalizacion);
        }

        Localizacion IRepositorioLocalizacion.UpdateLocalizacion(Localizacion localizacion)
        {
         var localizacionEncontrado = _appContext.Localizacion.FirstOrDefault(l => l.Id == localizacion.Id);
            if (localizacionEncontrado!=null)
            {
                localizacionEncontrado.Zona=localizacion.Zona;
                localizacionEncontrado.Latitud=localizacion.Latitud;
                localizacionEncontrado.Longitud=localizacion.Longitud;
                _appContext.SaveChanges();
            }
            return localizacionEncontrado;

        }
    }
}