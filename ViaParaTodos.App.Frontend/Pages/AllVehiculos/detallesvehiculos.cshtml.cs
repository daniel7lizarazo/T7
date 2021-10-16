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
    public class detallesvehiculosModel : PageModel
{
        private readonly IRepositorioVehiculos repositorioVehiculos;
        

        public Vehiculos vehiculo {get;set;}
        
        public detallesvehiculosModel(IRepositorioVehiculos repositorioVehiculos)
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



    }

    
}
