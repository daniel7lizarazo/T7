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
    public class ListModel : PageModel
    {

       // private string[] ciudadanos ={"Camilo","diego","Sandra", "juan", "nina"};

        //public List<string> ListaCiudadanos {get; set;}
        private readonly IRepositorioConductores repositorioConductores;
        public IEnumerable<Conductores> ListaConductores {get;set;}

        public ListModel(IRepositorioConductores repositorioConductores)
        {
            this.repositorioConductores=repositorioConductores;
        }
        public void OnGet()
        {
            ListaConductores=repositorioConductores.GetAllConductores();
            //ListaCiudadanos = new List<string>();
            //ListaCiudadanos.AddRange(ciudadanos);
        }
    }
}
