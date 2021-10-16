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
    public class CRUD_VehiculosModel : PageModel
    {
        private readonly IRepositorioVehiculos repositorioVehiculos;

        [BindProperty]
        public string placa {set;get;}
        //[BindProperty]
        public Vehiculos vehiculo {set;get;}

        public CRUD_VehiculosModel(IRepositorioVehiculos repositorioVehiculos) 
        {
            this.repositorioVehiculos=repositorioVehiculos;
        }

        public IActionResult OnPost()
        {
            //return new OkObjectResult(vehiculo);
            vehiculo=repositorioVehiculos.GetVehiculosByPlaca(placa);
            return Page();
/*            if(vehiculo==null)
            {
                return NotFound();
            }
            return new OkObjectResult(vehiculo);*/
        }
        public void OnGet()
        {
        }
    }
}
