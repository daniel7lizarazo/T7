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
    public class DetailsConductoresModel : PageModel
    {
        private readonly IRepositorioConductores repositorioConductores;

        public Conductores conductor {set;get;}

        public DetailsConductoresModel(IRepositorioConductores repositorioConductores)
        {
            this.repositorioConductores=repositorioConductores;
        }

        public void OnGet(int idconductor)
        {
            conductor = repositorioConductores.GetConductor(idconductor);
        }
    }
}
