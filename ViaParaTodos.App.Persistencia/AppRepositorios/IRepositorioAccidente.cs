using System.Collections.Generic;
using ViaParaTodos.App.Dominio.Entidades;

namespace ViaParaTodos.App.Persistencia.AppRepositorios
{
    public interface IRepositorioAccidente
    {
         
        IEnumerable<Accidente> GetAllAccidente();
        Accidente AddAccidente(Accidente accidente); 
        Accidente UpdateAccidente(Accidente accidente);
        void DeleteAccidente(int idAccidente);
        Accidente GetAccidente(int idAccidente);
        IEnumerable<TablaVC> GetTablaVCByAccidente(int accidenteId);
        IEnumerable<Accidente> GetLocalizacionAgentesByAccidente(int accidenteId);
        IEnumerable<Localizacion> GetOtrasLocalizaciones(int localizacionId);
        IEnumerable<AgentesTransito> GetAllAgentesTransitoAccidente();
        IEnumerable<Localizacion> GetAllLocalizacioneAccidente();
        int GetNumeroAccidentesLocalizacion(int localizacionId);
    }
    
}