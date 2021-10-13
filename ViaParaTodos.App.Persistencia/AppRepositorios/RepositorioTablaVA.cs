using System.Linq;
using System.Collections.Generic;
using ViaParaTodos.App.Dominio.Entidades;
namespace ViaParaTodos.App.Persistencia.AppRepositorios
{
    public class RepositorioTablaVA : IRepositorioTablaVA
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
        public RepositorioTablaVA(AppContext appContext)
        {
            _appContext=appContext;
        }

        TablaVA IRepositorioTablaVA.AddTablaVA(TablaVA tablaVA)
        {
            {
            var tablaVAAdicionado= _appContext.TablaVA.Add(tablaVA); 
            _appContext.SaveChanges();
            return tablaVAAdicionado.Entity;
            }
        }

        void IRepositorioTablaVA.DeleteTablaVA(int idTablaVA)
        {
            var tablaVAEncontrado = _appContext.TablaVA.FirstOrDefault(t => t.Id == idTablaVA);
            if(tablaVAEncontrado==null)
                return;
            _appContext.TablaVA.Remove(tablaVAEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<TablaVA> IRepositorioTablaVA.GetAllTablaVA()
        {
            return _appContext.TablaVA;
        }

       TablaVA IRepositorioTablaVA.GetTablaVA(int idTablaVA)
        {
            return _appContext.TablaVA.FirstOrDefault(t => t.Id == idTablaVA);
        }

        TablaVA IRepositorioTablaVA.UpdateTablaVA(TablaVA tablaVA)
        {
         var tablaVAEncontrado = _appContext.TablaVA.FirstOrDefault(t => t.Id == tablaVA.Id);
            if (tablaVAEncontrado!=null)
            {
                tablaVAEncontrado.VinculadosId=tablaVA.VinculadosId;
                tablaVAEncontrado.AccidenteId=tablaVA.AccidenteId;
                _appContext.SaveChanges();
            }
            return tablaVAEncontrado;
        }
    }
}