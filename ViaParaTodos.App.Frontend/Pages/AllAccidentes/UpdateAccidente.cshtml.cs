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
    public class UpdateAccidenteModel : PageModel
    {
        private readonly IRepositorioAccidente repositorioAccidente;
        private readonly IRepositorioTablaVC repositorioTablaVC;

        [BindProperty]
        public Accidente accidente {set;get;}

        [BindProperty]
        public string placa {set;get;}

        [BindProperty]
        public string numeroDoc {set;get;}

        public int accidenteId {set;get;}

        private Conductores conductor {set;get;}

        private Vehiculos vehiculo {set;get;}

        private TablaVC tablavc {set;get;}

        public IEnumerable<TablaVC> listTablaVC {set;get;}

        public IEnumerable<Accidente> accidente_localizacion_agente {set;get;}

        public IEnumerable<Localizacion> otras_localizaciones {set;get;}

        public UpdateAccidenteModel(IRepositorioAccidente repositorioAccidente, IRepositorioTablaVC repositorioTablaVC)
        {
            this.repositorioAccidente=repositorioAccidente;
            this.repositorioTablaVC=repositorioTablaVC;
        }

        public void OnGet(int idaccidente)
        {
            accidenteId = idaccidente;
            listTablaVC = repositorioAccidente.GetTablaVCByAccidente(idaccidente); 
            accidente = repositorioAccidente.GetAccidente(idaccidente);
            accidente_localizacion_agente = repositorioAccidente.GetLocalizacionAgentesByAccidente(idaccidente);
            foreach (Accidente accidente_local in accidente_localizacion_agente)
            {    
                otras_localizaciones = repositorioAccidente.GetOtrasLocalizaciones(accidente_local.Localizacion.Id);
            }
        }

        public IActionResult OnPostEditar(int idaccidente)
        {
            accidente = repositorioAccidente.UpdateAccidente(accidente);
            listTablaVC = repositorioAccidente.GetTablaVCByAccidente(idaccidente); 
            accidente_localizacion_agente = repositorioAccidente.GetLocalizacionAgentesByAccidente(idaccidente);
            foreach (Accidente accidente_local in accidente_localizacion_agente)
            {    
                otras_localizaciones = repositorioAccidente.GetOtrasLocalizaciones(accidente_local.Localizacion.Id);
            }
            return Page();
        }

        public IActionResult OnPostEliminarVC(int tablaVCId, int accidenteId)
        {
            repositorioAccidente.DeleteTablaVC(tablaVCId);

            listTablaVC = repositorioAccidente.GetTablaVCByAccidente(accidenteId); 
            accidente_localizacion_agente = repositorioAccidente.GetLocalizacionAgentesByAccidente(accidenteId);
            foreach (Accidente accidente_local in accidente_localizacion_agente)
            {    
                otras_localizaciones = repositorioAccidente.GetOtrasLocalizaciones(accidente_local.Localizacion.Id);
            }

            return Page();
        }

        public IActionResult OnPostAgregarVC(int accidenteId)
        {
            conductor = repositorioTablaVC.GetConductorByDocumento(numeroDoc);
            vehiculo = repositorioTablaVC.GetVehiculosByPlaca(placa);
            tablavc = new TablaVC {AccidenteId=accidenteId, ConductoresId=conductor.Id, VehiculosId=vehiculo.Id};
            tablavc = repositorioTablaVC.AddTablaVC(tablavc); 
        return Redirect("/AllAccidentes/UpdateAccidente?idaccidente="+accidenteId);
        }
    }
}
