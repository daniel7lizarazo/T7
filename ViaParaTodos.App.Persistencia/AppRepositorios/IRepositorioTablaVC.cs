using System.Collections.Generic;
using ViaParaTodos.App.Dominio.Entidades;
namespace ViaParaTodos.App.Persistencia.AppRepositorios
{
    public interface IRepositorioTablaVC
    {
         
        IEnumerable<TablaVC> GetAllTablaVC();
        TablaVC AddTablaVC(TablaVC tablaVC); 
        TablaVC UpdateTablaVC(TablaVC tablaVC);
        void DeleteTablaVC (int idTablaVC);
        TablaVC GetTablaVC (int idTablaVC);
        Conductores GetConductorByDocumento(string ConductorDocumento);
        Vehiculos GetVehiculosByPlaca(string PlacaVehiculo);
    }
}