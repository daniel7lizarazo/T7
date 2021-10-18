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
    public class ListVCModel : PageModel
    {
        private readonly IRepositorioAccidente repositorioAccidente;

        public IEnumerable<TablaVC> listTablaVC {set;get;}

        public IEnumerable<Accidente> accidente_localizacion_agente {set;get;} 

        public ListVCModel(IRepositorioAccidente repositorioAccidente)
        {
            this.repositorioAccidente=repositorioAccidente;
        }

        public void OnGet(int idaccidente)
        {
            listTablaVC = repositorioAccidente.GetTablaVCByAccidente(idaccidente); 
            accidente_localizacion_agente = repositorioAccidente.GetLocalizacionAgentesByAccidente(idaccidente);
        }
    }
}
