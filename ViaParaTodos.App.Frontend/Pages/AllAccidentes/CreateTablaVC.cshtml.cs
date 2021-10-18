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
    public class CreateTablaVCModel : PageModel
    {
        private readonly IRepositorioTablaVC repositorioTablaVC;

        [BindProperty]
        public string numeroDoc {set;get;}

        [BindProperty]
        public string placa {set;get;}
        
        public TablaVC tablavc {set;get;}

        public Conductores conductor {set;get;}

        public Vehiculos vehiculo {set;get;}

        public int accidenteId {set;get;}

        public CreateTablaVCModel(IRepositorioTablaVC repositorioTablaVC)
        {
            this.repositorioTablaVC=repositorioTablaVC;
        }

        public void OnGet(int idaccidente)
        {
            accidenteId = idaccidente;
        }

        public void OnPost(int idaccidente)
        {
            conductor = repositorioTablaVC.GetConductorByDocumento(numeroDoc);
            vehiculo = repositorioTablaVC.GetVehiculosByPlaca(placa);
            tablavc = new TablaVC {AccidenteId=idaccidente, ConductoresId=conductor.Id, VehiculosId=vehiculo.Id};
            tablavc = repositorioTablaVC.AddTablaVC(tablavc); 
            accidenteId = idaccidente;
            //return Page();
        }
    }
}
