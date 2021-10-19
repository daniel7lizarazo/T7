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
    public class EliminarVehiculosModel : PageModel
    {
        private readonly IRepositorioVehiculos repositorioVehiculos;
        private readonly IRepositorioTablaVC repositorioTablaVC;
        private readonly IRepositorioAccidente repositorioAccidente;

        public Vehiculos vehiculo {get;set;}

        public IEnumerable<TablaVC> tablavc {set;get;}

        private List<int> listaCV_eliminar {set;get;}

        public EliminarVehiculosModel(IRepositorioVehiculos repositorioVehiculos, IRepositorioTablaVC repositorioTablaVC, IRepositorioAccidente repositorioAccidente)
        {
            this.repositorioVehiculos=repositorioVehiculos;
            this.repositorioTablaVC=repositorioTablaVC;
            this.repositorioAccidente=repositorioAccidente;
        }

        public void OnGet(int idVehiculo)
        {
            vehiculo = repositorioVehiculos.GetVehiculos(idVehiculo);
            tablavc = repositorioTablaVC.GetAccidentesConductoresByVehiculo(idVehiculo);
        }

        public IActionResult OnPostEliminar(int idVehiculo)
        {
            listaCV_eliminar = new List<int> ();

            tablavc = repositorioTablaVC.GetAccidentesConductoresByVehiculo(idVehiculo);
            foreach (TablaVC tabla in tablavc)
            {
                listaCV_eliminar.Add(tabla.Id);
            }

            foreach (int tablaid in listaCV_eliminar)
            {
               repositorioTablaVC.DeleteTablaVC(tablaid);
            }

            repositorioVehiculos.DeleteVehiculos(idVehiculo);

            return Redirect("/AllVehiculos/ListVehiculos");
            //return new OkObjectResult(listaCV_eliminar);
        }
    }
}
