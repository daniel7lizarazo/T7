using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ViaParaTodos.App.Frontend.Pages
{
    public class CiudadanoConsultaModel : PageModel
    {
        //private readonly IRepositorioConductores repositorioConductores;
        [BindProperty]
        public string numeroDoc {set;get;}

        /*public ConsultaModel(IRepositorioConductores repositorioConductores)
        {
            this.repositorioConductores=repositorioConductores;
        }*/
        
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            return Redirect("/Ciudadano/Detalle?cedulaciudadano="+numeroDoc);
        }

    }
}
