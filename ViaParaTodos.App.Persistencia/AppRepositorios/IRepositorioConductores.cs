using System.Security.AccessControl;
using System.Collections.Generic;
using ViaParaTodos.App.Dominio.Entidades;

namespace ViaParaTodos.App.Persistencia.AppRepositorios
{
    public interface IRepositorioConductores
    {
        IEnumerable<Conductores> GetAllConductores();
        Conductores AddConductor(Conductores conductor); 
        Conductores UpdateConductor(Conductores conductor);
        void DeleteConductores(int idConductor);
        Conductores GetConductor(int idConductor);
    }
}