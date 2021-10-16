using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiInHome.App.Dominio.Entidades;
using HospiInHome.App.Persistencia.AppRepositorios;

namespace HospiInHome.App.FrontEnd.Pages
{
    public class ListPacientesModel : PageModel
    {
        /* private static IRepoPaciente _repoPaciente = new RepoPaciente(new Persistencia.AppContext()); */

        
        /* private readonly IRepoPaciente repoPaciente; */
        /* IEnumerable<Paciente> Pacientes {get;set;}
        public static void ListarPaciente(IRepoPaciente repoPaciente)
        {
            _repoPaciente = _repoPaciente;
        } */
        

        public void OnGet()
        {
            /* var paciente = repoPaciente.GetAllPacientes(); */
        }

        /* public static void ListarPaciente()
        {
            var paciente = _repoPaciente.GetAllPacientes();
        } */
    }
}
