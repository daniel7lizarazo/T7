using System.Linq;
using System.Collections.Generic;
using ViaParaTodos.App.Dominio.Entidades;

namespace ViaParaTodos.App.Persistencia.AppRepositorios
{
    public class RepositorioConductores:IRepositorioConductores
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
        public RepositorioConductores(AppContext appContext)
        {
            _appContext=appContext;
        }
        IEnumerable<Conductores> IRepositorioConductores.GetAllConductores()
        {
            return _appContext.Conductores;
        }
        Conductores IRepositorioConductores.AddConductor(Conductores conductor)
        {
           var conductorAdicionado= _appContext.Conductores.Add(conductor); 
           _appContext.SaveChanges();
           return conductorAdicionado.Entity;
        }
        Conductores IRepositorioConductores.UpdateConductor(Conductores conductor)
        {
        var ConductorEncontrado = _appContext.Conductores.FirstOrDefault(c => c.Id == conductor.Id);
            if (ConductorEncontrado!=null)
            {
                ConductorEncontrado.Nombres=conductor.Nombres;
                ConductorEncontrado.Apellidos=conductor.Apellidos;
                ConductorEncontrado.TipoDoc=conductor.TipoDoc;
                ConductorEncontrado.NumeroDoc=conductor.NumeroDoc;
                ConductorEncontrado.Direccion=conductor.Direccion;
                ConductorEncontrado.NumeroTelefono=conductor.NumeroTelefono;
                ConductorEncontrado.VigenciaLicencia=conductor.VigenciaLicencia;
                _appContext.SaveChanges();
            }
            return ConductorEncontrado;
        }
        void IRepositorioConductores.DeleteConductores(int idConductor)
        {
            var ConductorEncontrado = _appContext.Conductores.FirstOrDefault(c => c.Id == idConductor);
            if(ConductorEncontrado==null)
                return;
            _appContext.Conductores.Remove(ConductorEncontrado);
            _appContext.SaveChanges();
        }
        Conductores IRepositorioConductores.GetConductor(int idConductor)
        {
            
            return _appContext.Conductores.FirstOrDefault(c => c.Id == idConductor);
        }
 
    }
}