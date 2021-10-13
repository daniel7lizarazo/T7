using System.Linq;
using System.Collections.Generic;
using ViaParaTodos.App.Dominio.Entidades;

namespace ViaParaTodos.App.Persistencia.AppRepositorios
{
    public class RepositorioVehiculos : IRepositorioVehiculos
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
        public RepositorioVehiculos(AppContext appContext)
        {
            _appContext=appContext;
        }

        Vehiculos IRepositorioVehiculos.AddVehiculos(Vehiculos vehiculo)
        {
           var vehiculoAdicionado= _appContext.Vehiculos.Add(vehiculo); 
           _appContext.SaveChanges();
           return vehiculoAdicionado.Entity;
        }

        void IRepositorioVehiculos.DeleteVehiculos(int idVehiculo)
        {
            var vehiculoEncontrado = _appContext.Vehiculos.FirstOrDefault(v => v.Id == idVehiculo);
            if(vehiculoEncontrado==null)
                return;
            _appContext.Vehiculos.Remove(vehiculoEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Vehiculos> IRepositorioVehiculos.GetAllVehiculos()
        {
            return _appContext.Vehiculos;
        }

        Vehiculos IRepositorioVehiculos.GetVehiculosByPlaca(string PlacaVehiculo)
        {
            return _appContext.Vehiculos.FirstOrDefault(v => v.Placa == PlacaVehiculo);
        }

        Vehiculos IRepositorioVehiculos.GetVehiculos(int idVehiculo)
        {
            return _appContext.Vehiculos.FirstOrDefault(v => v.Id == idVehiculo);
        }

        Vehiculos IRepositorioVehiculos.UpdateVehiculos(Vehiculos vehiculo)
        {
        var vehiculoEncontrado = _appContext.Vehiculos.FirstOrDefault(v => v.Id == vehiculo.Id);
            if (vehiculoEncontrado!=null)
            {
                vehiculoEncontrado.Placa=vehiculo.Placa;
                vehiculoEncontrado.Modelo=vehiculo.Modelo;
                vehiculoEncontrado.Marca=vehiculo.Marca;
                vehiculoEncontrado.Linea=vehiculo.Linea;
                vehiculoEncontrado.Color=vehiculo.Color;
                _appContext.SaveChanges();
            }
            return vehiculoEncontrado;

        }
    }
}