using System.Linq;
using System.Collections.Generic;
using ViaParaTodos.App.Dominio.Entidades;
namespace ViaParaTodos.App.Persistencia.AppRepositorios
{
    public class RepositorioVinculados : IRepositorioVinculados
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
        public RepositorioVinculados(AppContext appContext)
        {
            _appContext=appContext;
        }
        Vinculados IRepositorioVinculados.AddVinculados(Vinculados vinculado)
        {
           var vinculadoAdicionado= _appContext.Vinculados.Add(vinculado); 
           _appContext.SaveChanges();
           return vinculadoAdicionado.Entity;
        }

        void IRepositorioVinculados.DeleteVinculados(int idVinculados)
        {
            var vinculadoEncontrado = _appContext.Vinculados.FirstOrDefault(v => v.Id == idVinculados);
            if(vinculadoEncontrado==null)
                return;
            _appContext.Vinculados.Remove(vinculadoEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Vinculados> IRepositorioVinculados.GetAllVinculados()
        {
            return _appContext.Vinculados;
        }

        Vinculados IRepositorioVinculados.GetVinculados(int idVinculados)
        {
            return _appContext.Vinculados.FirstOrDefault(v => v.Id == idVinculados);
        }

        Vinculados IRepositorioVinculados.UpdateVinculados(Vinculados vinculado)
        {
        var vinculadoEncontrado = _appContext.Vinculados.FirstOrDefault(v => v.Id == vinculado.Id);
            if (vinculadoEncontrado!=null)
            {
                vinculadoEncontrado.Nombres=vinculado.Nombres;
                vinculadoEncontrado.Apellidos=vinculado.Apellidos;
                vinculadoEncontrado.TipoDoc=vinculado.TipoDoc;
                vinculadoEncontrado.NumeroDoc=vinculado.NumeroDoc;
                vinculadoEncontrado.Direccion=vinculado.Direccion;
                vinculadoEncontrado.NumeroTelefono=vinculado.NumeroTelefono;
                vinculadoEncontrado.Testigo=vinculado.Testigo;
                vinculadoEncontrado.Afectado=vinculado.Afectado;
                vinculadoEncontrado.VinculadosAccidenteId=vinculado.VinculadosAccidenteId;
                _appContext.SaveChanges();
            }
            return vinculadoEncontrado;

        }
    }
}