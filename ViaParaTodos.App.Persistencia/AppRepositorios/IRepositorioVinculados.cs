using System.Collections.Generic;
using ViaParaTodos.App.Dominio.Entidades;
namespace ViaParaTodos.App.Persistencia.AppRepositorios
{
    public interface IRepositorioVinculados
    {
         
        IEnumerable<Vinculados> GetAllVinculados();
        Vinculados AddVinculados(Vinculados vinculado); 
        Vinculados UpdateVinculados(Vinculados vinculado);
        void DeleteVinculados(int idVinculados);
        Vinculados GetVinculados(int idVinculados);
    }
}