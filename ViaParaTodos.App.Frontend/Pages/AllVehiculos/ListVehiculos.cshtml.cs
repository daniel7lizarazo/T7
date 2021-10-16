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
    public class ListVehiculosModel : PageModel
    {
        private readonly IRepositorioVehiculos repositorioVehiculos;
        public IEnumerable<Vehiculos> ListaVehiculos{get;set;}

        public ListVehiculosModel(IRepositorioVehiculos repositorioVehiculos)
        {
            this.repositorioVehiculos=repositorioVehiculos;
        }
        public void OnGet()
        {
            ListaVehiculos=repositorioVehiculos.GetAllVehiculos();
        }
    }
}
