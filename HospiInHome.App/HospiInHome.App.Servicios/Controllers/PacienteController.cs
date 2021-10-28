using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HospiInHome.App.Persistencia.AppRepositorios;

namespace HospiInHome.App.Servicios.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PacienteController : ControllerBase
    {
        private readonly IRepoPaciente _repoPaciente;
        public PacienteController(IRepoPaciente repoPaciente)
        {
            this._repoPaciente = repoPaciente;
        }
    }
}