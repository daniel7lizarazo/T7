using System.Collections.Generic;
using ViaParaTodos.App.Dominio.Entidades;
namespace ViaParaTodos.App.Persistencia.AppRepositorios
{
    public interface IRepositorioAgentesTransito
    {
         
        IEnumerable<AgentesTransito> GetAllAgentesTransito();
        AgentesTransito AddAgentesTransito(AgentesTransito angenteTransito); 
        AgentesTransito UpdateAgentesTransito(AgentesTransito angenteTransito);
        void DeleteAgentesTransito(int idAgentesTransito);
        AgentesTransito GetAgentesTransito (int idAgentesTransito);
        AgentesTransito GetAgentesTransitoByIdentificacion (string idAgentesTransito);
    }
}