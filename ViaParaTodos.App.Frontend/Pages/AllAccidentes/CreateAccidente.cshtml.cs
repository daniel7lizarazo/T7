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
    public class CreateAccidenteModel : PageModel
    {
        private readonly IRepositorioAccidente repositorioAccidente;

        [BindProperty]
        public Accidente accidente {set;get;}

        public IEnumerable<AgentesTransito> agentes {set;get;}

        public IEnumerable<Localizacion> localizaciones {set;get;}
        
        public CreateAccidenteModel(IRepositorioAccidente repositorioAccidente)
        {
            this.repositorioAccidente=repositorioAccidente;
        }

        public void OnGet()
        {
            agentes = repositorioAccidente.GetAllAgentesTransitoAccidente();
            localizaciones = repositorioAccidente.GetAllLocalizacioneAccidente();
        }

        public IActionResult OnPost()
        {
            accidente = repositorioAccidente.AddAccidente(accidente);
            return Redirect("/AllAccidentes/CreateTablaVC?idaccidente="+accidente.Id);
        }
    }
}
