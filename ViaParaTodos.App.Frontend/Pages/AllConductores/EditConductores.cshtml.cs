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
    public class EditConductoresModel : PageModel
    {

        private readonly IRepositorioConductores repositorioConductores;

        [BindProperty]
        public Conductores conductor {get;set;}
        
        public EditConductoresModel(IRepositorioConductores repositorioConductores)
        {
            this.repositorioConductores=repositorioConductores;
        }
      
        public IActionResult OnGet(int idConductor)
        {
            conductor=repositorioConductores.GetConductor(idConductor);
            if (conductor==null)
            {
                return RedirectToPage("./NotFound");
            }
            else 
            return Page();
        }

        public IActionResult OnPost()
        {
            conductor=repositorioConductores.UpdateConductor(conductor);
            return Page();
        }
    }

    
}
