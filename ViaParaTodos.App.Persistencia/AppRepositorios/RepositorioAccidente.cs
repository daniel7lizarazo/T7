using System.Linq;
using System.Collections.Generic;
using ViaParaTodos.App.Dominio.Entidades;
namespace ViaParaTodos.App.Persistencia.AppRepositorios
{
    public class RepositorioAccidente : IRepositorioAccidente
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
        public RepositorioAccidente(AppContext appContext)
        {
            _appContext=appContext;
        }


        Accidente IRepositorioAccidente.AddAccidente(Accidente accidente)
        {
           var accidenteAdicionado= _appContext.Accidente.Add(accidente); 
           _appContext.SaveChanges();
           return accidenteAdicionado.Entity;
        }

        void IRepositorioAccidente.DeleteAccidente(int idAccidente)
        {
            var accidenteEncontrado = _appContext.Accidente.FirstOrDefault(a => a.Id == idAccidente);
            if(accidenteEncontrado==null)
                return;
            _appContext.Accidente.Remove(accidenteEncontrado);
            _appContext.SaveChanges();
        }

        Accidente IRepositorioAccidente.GetAccidente(int idAccidente)
        {
            return _appContext.Accidente.FirstOrDefault(a => a.Id == idAccidente);
        }

        IEnumerable<Accidente> IRepositorioAccidente.GetAllAccidente()
        {
            return _appContext.Accidente;
        }

        Accidente IRepositorioAccidente.UpdateAccidente(Accidente accidente)
        {
        var accidenteEncontrado = _appContext.Accidente.FirstOrDefault(a => a.Id == accidente.Id);
            if (accidenteEncontrado!=null)
            {
                accidenteEncontrado.Fecha=accidente.Fecha;
                accidenteEncontrado.Descripcion=accidente.Descripcion;
                accidenteEncontrado.Gravedad=accidente.Gravedad;
                accidenteEncontrado.AgentesTransitoId=accidente.AgentesTransitoId;
                accidenteEncontrado.LocalizacionId=accidente.LocalizacionId;
                _appContext.SaveChanges();
            }
            return accidenteEncontrado;

        }
    }
}