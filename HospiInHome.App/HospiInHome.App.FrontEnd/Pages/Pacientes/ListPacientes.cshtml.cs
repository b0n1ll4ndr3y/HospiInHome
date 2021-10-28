using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiInHome.App.Dominio.Entidades;
using HospiInHome.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Authorization;

namespace HospiInHome.App.FrontEnd.Pages
{
    public class ListPacientesModel : PageModel
    {
        private readonly IRepoPaciente _repoPaciente;
        public IEnumerable<Paciente> Pacientes {get;set;}
        public Paciente Paciente {get;set;}
        public ListPacientesModel()
        {
            this._repoPaciente = new RepoPaciente(new HospiInHome.App.Persistencia.AppContext());
        }

        public void OnGet()
        {
            Pacientes = _repoPaciente.GetAllPacientes();   
        }
    }
}
