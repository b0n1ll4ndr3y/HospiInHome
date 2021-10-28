using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiInHome.App.Persistencia.AppRepositorios;
using HospiInHome.App.Dominio.Entidades;

namespace HospiInHome.App.FrontEnd.Pages
{
    public class DetallesPModel : PageModel
    {
        private readonly IRepoPaciente _repoPaciente;
        public Paciente Paciente {get; set;}
        public FamiliarDesignado FamiliarDesignado {get; set;}
        public Medico Medico {get; set;}
        public Enfermera Enfermera {get; set;}
        public DetallesPModel()
        {
            this._repoPaciente = new RepoPaciente(new HospiInHome.App.Persistencia.AppContext());

        }
        public IActionResult OnGet(int idPaciente)
        {
            Paciente = _repoPaciente.GetPaciente(idPaciente);
            if (Paciente == null)
            {
                return RedirectToPage("./NotFound");
            }
            else{
                FamiliarDesignado = _repoPaciente.GetFamiliarDesignado(idPaciente);
                Medico = _repoPaciente.GetMedicoAsignado(idPaciente);

                Enfermera = _repoPaciente.GetEnfermeraAsignada(idPaciente);
                return Page();
            }
        }
    }
}
