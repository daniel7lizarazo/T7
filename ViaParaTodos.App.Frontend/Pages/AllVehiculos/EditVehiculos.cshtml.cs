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

    public class EditVehiculosModel : PageModel
    {

        private readonly IRepositorioConductores repositorioConductores;
        private readonly IRepositorioVehiculos repositorioVehiculos;

        [BindProperty]
        public Vehiculos vehiculo {get;set;}
        
        public EditVehiculosModel(IRepositorioVehiculos repositorioVehiculos, IRepositorioConductores repositorioConductores)
        {
             
            this.repositorioVehiculos=repositorioVehiculos;
        }


      
        public IActionResult OnGet(int idVehiculo)
        {
     
            vehiculo=repositorioVehiculos.GetVehiculos(idVehiculo);
            if (vehiculo==null)
            {
                return RedirectToPage("./NotFound");
            }
            else 
            return Page();
            
        }

        
        public IActionResult OnPost()
        {
     
            vehiculo=repositorioVehiculos.UpdateVehiculos(vehiculo);
            return Page();
            
        }



    }

    
}
