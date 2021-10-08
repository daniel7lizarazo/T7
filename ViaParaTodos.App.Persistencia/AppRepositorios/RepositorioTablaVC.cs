using System.Linq;
using System.Collections.Generic;
using ViaParaTodos.App.Dominio.Entidades;
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
                tablaVCEncontrado.VehiculosTablaVCId=tablaVC.VehiculosTablaVCId;
                tablaVCEncontrado.ConductoresTablaVCId=tablaVC.ConductoresTablaVCId;
                tablaVCEncontrado.AccidenteTablaVCId=tablaVC.AccidenteTablaVCId;
                _appContext.SaveChanges();
            }
            return tablaVCEncontrado;
        }
    }
}