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
    public class RegiPacientesModel : PageModel
    {
        private readonly IRepoPaciente _repoPaciente;
        [BindProperty]
        public Paciente Paciente { get; set; }
        public Genero Genero { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public FamiliarDesignado FamiliarDesignado {get; set;}
        public RegiPacientesModel()
        {
            this._repoPaciente = new RepoPaciente(new HospiInHome.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int? idPaciente, int? idFamiliarDesignado)
        {
            if (idPaciente.HasValue)
            {
                Paciente = _repoPaciente.GetPaciente(idPaciente.Value);
            }
            else
            {
                Paciente = new Paciente();
            }
            if (Paciente == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                FamiliarDesignado = _repoPaciente.GetFamiliarDesignado(idFamiliarDesignado.Value);
                return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (Paciente.Id > 0)
            {
                Paciente = _repoPaciente.UpdatePaciente(Paciente);
            }
            else
            {
                _repoPaciente.AddPaciente(Paciente);
            }
            return Page();
        }
    }
}
