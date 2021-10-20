using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ViaParaTodos.App.Dominio.Entidades;
using ViaParaTodos.App.Persistencia.AppRepositorios;

namespace ViaParaTodos.App.Frontend.Pages
{
    public class DetalleModel : PageModel
    {
        private readonly IRepositorioConductores repositorioConductores;
        private readonly IRepositorioTablaVC repositorioTablaVC;
        private readonly IRepositorioAccidente repositorioAccidente;

        public Conductores ciudadano {get;set;}

        public IEnumerable<TablaVC> tablavc {set;get;}

        public DetalleModel(IRepositorioConductores repositorioConductores, IRepositorioTablaVC repositorioTablaVC, IRepositorioAccidente repositorioAccidente)
        {
            this.repositorioConductores=repositorioConductores;
            this.repositorioTablaVC=repositorioTablaVC;
            this.repositorioAccidente=repositorioAccidente;
        }

        public void OnGet(string cedulaciudadano)
        {
            ciudadano=repositorioConductores.GetConductorByDocumento(cedulaciudadano);
            tablavc = repositorioTablaVC.GetAccidentesVehiculosByConductor(ciudadano.Id);
        }
    }
}
