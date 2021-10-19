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
    public class EliminarConductoresModel : PageModel
    {
        private readonly IRepositorioConductores repositorioConductores;
        private readonly IRepositorioTablaVC repositorioTablaVC;
        private readonly IRepositorioAccidente repositorioAccidente;

        public Conductores conductor {get;set;}

        public IEnumerable<TablaVC> tablavc {set;get;}

        private List<int> listaCV_eliminar {set;get;}

        public EliminarConductoresModel(IRepositorioConductores repositorioConductores, IRepositorioTablaVC repositorioTablaVC, IRepositorioAccidente repositorioAccidente)
        {
            this.repositorioConductores=repositorioConductores;
            this.repositorioTablaVC=repositorioTablaVC;
            this.repositorioAccidente=repositorioAccidente;
        }

        public void OnGet(int idconductor)
        {
            conductor = repositorioConductores.GetConductor(idconductor);
            tablavc = repositorioTablaVC.GetAccidentesVehiculosByConductor(idconductor);
        }

        public IActionResult OnPostEliminar(int idconductor)
        {
            listaCV_eliminar = new List<int> ();

            tablavc = repositorioTablaVC.GetAccidentesVehiculosByConductor(idconductor);
            foreach (TablaVC tabla in tablavc)
            {
                listaCV_eliminar.Add(tabla.Id);
            }

            foreach (int tablaid in listaCV_eliminar)
            {
               repositorioTablaVC.DeleteTablaVC(tablaid);
            }

            repositorioConductores.DeleteConductores(idconductor);

            return Redirect("/AllConductores/ListConductores");
            //return new OkObjectResult(listaCV_eliminar);
        }
    }
}
