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
    public class ListAccidentesModel : PageModel
    {
        private readonly IRepositorioAccidente repositorioAccidente;
        public IEnumerable<Accidente> ListaAccidentes{get;set;}

        public ListAccidentesModel(IRepositorioAccidente repositorioAccidente)
        {
            this.repositorioAccidente=repositorioAccidente;
        }
        public void OnGet()
        {
            ListaAccidentes=repositorioAccidente.GetAllAccidente();
        }
    }
}

