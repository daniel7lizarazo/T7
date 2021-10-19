using System.Linq;
using System.Collections.Generic;
using ViaParaTodos.App.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
namespace ViaParaTodos.App.Persistencia.AppRepositorios
{
    public class RepositorioTablaVC : IRepositorioTablaVC
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
        public RepositorioTablaVC(AppContext appContext)
        {
            _appContext=appContext;
        }

        IEnumerable<TablaVC> IRepositorioTablaVC.GetAccidentesConductoresByVehiculo(int vehiculoId)
        {
            return _appContext.TablaVC.Where(t=>t.VehiculosId==vehiculoId).Include(t=>t.Accidente).Include(t=>t.Conductores);
        }
        
        IEnumerable<TablaVC> IRepositorioTablaVC.GetAccidentesVehiculosByConductor(int conductorId)
        {
            return _appContext.TablaVC.Where(t=>t.ConductoresId==conductorId).Include(t=>t.Accidente).Include(t=>t.Vehiculos);
        }

        Vehiculos IRepositorioTablaVC.GetVehiculosByPlaca(string PlacaVehiculo)
        {
            return _appContext.Vehiculos.FirstOrDefault(v => v.Placa == PlacaVehiculo);
        }

        Conductores IRepositorioTablaVC.GetConductorByDocumento(string ConductorDocumento)
        {
            return _appContext.Conductores.FirstOrDefault(c => c.NumeroDoc == ConductorDocumento);
        }

        TablaVC IRepositorioTablaVC.AddTablaVC(TablaVC tablaVC)
        {
            {
            var tablaVCAdicionado= _appContext.TablaVC.Add(tablaVC); 
            _appContext.SaveChanges();
            return tablaVCAdicionado.Entity;
            }
        }

        void IRepositorioTablaVC.DeleteTablaVC(int idTablaVC)
        {
            var tablaVCEncontrado = _appContext.TablaVC.FirstOrDefault(t => t.Id == idTablaVC);
            if(tablaVCEncontrado==null)
                return;
            _appContext.TablaVC.Remove(tablaVCEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<TablaVC> IRepositorioTablaVC.GetAllTablaVC()
        {
            return _appContext.TablaVC;
        }

        TablaVC IRepositorioTablaVC.GetTablaVC(int idTablaVC)
        {
            return _appContext.TablaVC.FirstOrDefault(t => t.Id == idTablaVC);
        }

        TablaVC IRepositorioTablaVC.UpdateTablaVC(TablaVC tablaVC)
        {
         var tablaVCEncontrado = _appContext.TablaVC.FirstOrDefault(t => t.Id == tablaVC.Id);
            if (tablaVCEncontrado!=null)
            {
                tablaVCEncontrado.VehiculosId=tablaVC.VehiculosId;
                tablaVCEncontrado.ConductoresId=tablaVC.ConductoresId;
                tablaVCEncontrado.AccidenteId=tablaVC.AccidenteId;
                _appContext.SaveChanges();
            }
            return tablaVCEncontrado;
        }
    }
}