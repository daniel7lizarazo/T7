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
    public class CreateVehiculosModel : PageModel
    {
        private readonly IRepositorioVehiculos repositorioVehiculos;

        [BindProperty]
        public Vehiculos vehiculo {get;set;}

        public CreateVehiculosModel(IRepositorioVehiculos repositorioVehiculos)
        {
            this.repositorioVehiculos=repositorioVehiculos;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            vehiculo=repositorioVehiculos.AddVehiculos(vehiculo);
            return Redirect("/AllVehiculos/EditVehiculos?idVehiculo="+vehiculo.Id);
        }
    }
}
