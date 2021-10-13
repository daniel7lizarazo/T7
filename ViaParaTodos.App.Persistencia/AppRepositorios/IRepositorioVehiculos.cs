using System.Collections.Generic;
using ViaParaTodos.App.Dominio.Entidades;

namespace ViaParaTodos.App.Persistencia.AppRepositorios
{
    public interface IRepositorioVehiculos
    {    
        IEnumerable<Vehiculos> GetAllVehiculos();
        Vehiculos AddVehiculos(Vehiculos vehiculo); 
        Vehiculos UpdateVehiculos(Vehiculos vehiculo);
        void DeleteVehiculos (int idVehiculo);
        Vehiculos GetVehiculos (int idVehiculo);
        Vehiculos GetVehiculosByPlaca (string PlacaVehiculo);
    }
}