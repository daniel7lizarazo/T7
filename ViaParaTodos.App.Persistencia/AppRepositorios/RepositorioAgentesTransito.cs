using System.Linq;
using System.Collections.Generic;
using ViaParaTodos.App.Dominio.Entidades;
namespace ViaParaTodos.App.Persistencia.AppRepositorios
{
    public class RepositorioAgentesTransito : IRepositorioAgentesTransito
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
        public RepositorioAgentesTransito(AppContext appContext)
        {
            _appContext=appContext;
        }
        AgentesTransito IRepositorioAgentesTransito.AddAgentesTransito(AgentesTransito angenteTransito)
        {
           var angenteTransitoAdicionado= _appContext.AgentesTransito.Add(angenteTransito); 
           _appContext.SaveChanges();
           return angenteTransitoAdicionado.Entity;
        }

        void IRepositorioAgentesTransito.DeleteAgentesTransito(int idAgentesTransito)
        {
            var angenteTransitoEncontrado = _appContext.AgentesTransito.FirstOrDefault(a => a.Id == idAgentesTransito);
            if(angenteTransitoEncontrado==null)
                return;
            _appContext.AgentesTransito.Remove(angenteTransitoEncontrado);
            _appContext.SaveChanges();
        }

        AgentesTransito IRepositorioAgentesTransito.GetAgentesTransito(int idAgentesTransito)
        {
            return _appContext.AgentesTransito.FirstOrDefault(a => a.Id == idAgentesTransito);
        }

        IEnumerable<AgentesTransito> IRepositorioAgentesTransito.GetAllAgentesTransito()
        {
            return _appContext.AgentesTransito;
        }

        AgentesTransito IRepositorioAgentesTransito.UpdateAgentesTransito(AgentesTransito angenteTransito)
        {
        var angenteTransitoEncontrado = _appContext.AgentesTransito.FirstOrDefault(a => a.Id == angenteTransito.Id);
            if (angenteTransitoEncontrado!=null)
            {
                angenteTransitoEncontrado.Usuario=angenteTransito.Usuario;
                angenteTransitoEncontrado.Contrasena=angenteTransito.Contrasena;
                angenteTransitoEncontrado.Identificacion=angenteTransito.Identificacion;
                angenteTransitoEncontrado.Rango=angenteTransito.Rango;
                _appContext.SaveChanges();
            }
            return angenteTransitoEncontrado;
        }
    }
}