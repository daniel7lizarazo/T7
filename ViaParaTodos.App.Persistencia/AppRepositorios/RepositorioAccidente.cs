using System.Linq;
using System.Collections.Generic;
using ViaParaTodos.App.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

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

        void IRepositorioAccidente.DeleteTablaVC(int idTablaVC)
        {
            var tablaVCEncontrado = _appContext.TablaVC.FirstOrDefault(t => t.Id == idTablaVC);
            if(tablaVCEncontrado==null)
                return;
            _appContext.TablaVC.Remove(tablaVCEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<AgentesTransito> IRepositorioAccidente.GetAllAgentesTransitoAccidente()
        {
            return _appContext.AgentesTransito;
        }

        IEnumerable<Localizacion> IRepositorioAccidente.GetAllLocalizacioneAccidente()
        {
            return _appContext.Localizacion;
        }

        IEnumerable<Localizacion> IRepositorioAccidente.GetOtrasLocalizaciones(int localizacionId)
        {
            return _appContext.Localizacion.Where(l=>l.Id != localizacionId);
        }

        IEnumerable<Accidente> IRepositorioAccidente.GetLocalizacionAgentesByAccidente(int accidenteId)
        {
            return _appContext.Accidente.Where(a=>a.Id == accidenteId).Include(a=>a.Localizacion).Include(a=>a.AgentesTransito).ToList();
        }

        IEnumerable<TablaVC> IRepositorioAccidente.GetTablaVCByAccidente(int accidenteId)
        {
            return _appContext.TablaVC.Where(t=>t.AccidenteId==accidenteId).Include(t=>t.Vehiculos).Include(t=>t.Conductores).ToList();
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