using System.Collections.Generic;
using ViaParaTodos.App.Dominio.Entidades;
namespace ViaParaTodos.App.Persistencia.AppRepositorios
{
    public interface IRepositorioTablaVA
    {
         
        IEnumerable<TablaVA> GetAllTablaVA();
        TablaVA AddTablaVA(TablaVA tablaVA); 
        TablaVA UpdateTablaVA(TablaVA tablaVA);
        void DeleteTablaVA (int idTablaVA);
        TablaVA GetTablaVA (int idTablaVA);
    }
}