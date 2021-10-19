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
    public class CreateConductoresModel : PageModel
    {
        private readonly IRepositorioConductores repositorioConductores;

        [BindProperty]
        public Conductores conductor {get;set;}

        public CreateConductoresModel(IRepositorioConductores repositorioConductores)
        {
            this.repositorioConductores=repositorioConductores;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            conductor=repositorioConductores.AddConductor(conductor);
            return Redirect("/AllConductores/EditConductores?idconductor="+conductor.Id);
        }
    }
}
