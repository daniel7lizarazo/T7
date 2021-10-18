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
    public class DeleteAccidenteModel : PageModel
    {
        private readonly IRepositorioAccidente repositorioAccidente;

        public IEnumerable<TablaVC> listTablaVC {set;get;}

        public IEnumerable<Accidente> accidente_localizacion_agente {set;get;}

        public int accidenteId {set;get;}

        public DeleteAccidenteModel(IRepositorioAccidente repositorioAccidente)
        {
            this.repositorioAccidente=repositorioAccidente;
        }

        public void OnGet(int idaccidente)
        {
            listTablaVC = repositorioAccidente.GetTablaVCByAccidente(idaccidente); 
            accidente_localizacion_agente = repositorioAccidente.GetLocalizacionAgentesByAccidente(idaccidente);
            accidenteId = idaccidente;
        }

        public IActionResult OnPostEliminar(int accidenteId)
        {
            listTablaVC = repositorioAccidente.GetTablaVCByAccidente(accidenteId); 
            foreach (TablaVC tabla in listTablaVC)
            {
                repositorioAccidente.DeleteTablaVC(tabla.Id);
            }

            repositorioAccidente.DeleteAccidente(accidenteId);

            return Redirect("/AllAccidentes/ListAccidentes");
        }

        public IActionResult OnPostCancelar()
        {
            return Redirect("/AllAccidentes/ListAccidentes");
        }
    }
}
