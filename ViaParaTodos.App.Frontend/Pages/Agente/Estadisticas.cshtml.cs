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
    public class EstadisticasModel : PageModel
    {
        private readonly IRepositorioAccidente repositorioAccidente;
        private readonly IRepositorioLocalizacion repositorioLocalizacion;

        private int numAccidentes {set;get;}

        private IEnumerable<Localizacion> listLocalizacion {set;get;}

        public List<string[]> lista_localizacion_numAccidentes {set;get;}

        public List<Localizacion> lista_localizacion_prov {set;get;}

        private string[] lista_prov {set;get;}

        public EstadisticasModel(IRepositorioLocalizacion repositorioLocalizacion,IRepositorioAccidente repositorioAccidente)
        {
            this.repositorioAccidente=repositorioAccidente;
            this.repositorioLocalizacion=repositorioLocalizacion;
        }

        public void OnGet()
        {
            lista_localizacion_numAccidentes  = new List<string[]> ();
            lista_localizacion_prov  = new List<Localizacion> ();
            listLocalizacion=repositorioLocalizacion.GetAllLocalizacion();

            foreach (Localizacion local in listLocalizacion)
            {
               lista_localizacion_prov .Add(local) ;
            }

            foreach (Localizacion localizacion in lista_localizacion_prov )
            {
                numAccidentes=repositorioAccidente.GetNumeroAccidentesLocalizacion(localizacion.Id);
                string [] lista_prov = {localizacion.Zona, numAccidentes.ToString()};
                lista_localizacion_numAccidentes.Add(lista_prov);
            }
        }

    }
}
