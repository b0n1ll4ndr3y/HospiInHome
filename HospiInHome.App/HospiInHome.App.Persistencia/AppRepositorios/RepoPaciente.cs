using System.Collections;
using System.Collections.Generic;
using System.Linq;
using HospiInHome.App.Dominio.Entidades;

namespace HospiInHome.App.Persistencia.AppRepositorios
{
    public class RepoPaciente : IRepoPaciente
    {
        private readonly AppContext _appContext;

        public RepoPaciente(AppContext appContext)
        {
            _appContext=appContext;
        }

        Paciente IRepoPaciente.AddPaciente(Paciente paciente)
        {
            var pacienteAdicionado = _appContext.Pacientes.Add(paciente);
            _appContext.SaveChanges();
            return pacienteAdicionado.Entity;
        }

        void IRepoPaciente.DeletePaciente(int idPaciente)
        {
            var pacienteEncontrado= _appContext.Pacientes.FirstOrDefault(p => p.Id==idPaciente);
            if(pacienteEncontrado==null)
                return;
            _appContext.Pacientes.Remove(pacienteEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Paciente> IRepoPaciente.GetAllPacientes()
        {
            return _appContext.Pacientes;
        }

        Paciente IRepoPaciente.GetPaciente(int idPaciente)
        {
            return _appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
        }

        Paciente IRepoPaciente.UpdatePaciente(Paciente paciente)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == paciente.Id);
            if (pacienteEncontrado != null)
            {
                pacienteEncontrado.Nombre = paciente.Nombre;
                pacienteEncontrado.Apellido = paciente.Apellido;
                pacienteEncontrado.Telefono = paciente.Telefono;
                pacienteEncontrado.Genero = paciente.Genero;
                pacienteEncontrado.TipoDocumento = paciente.TipoDocumento;
                pacienteEncontrado.Documento = paciente.Documento;
                pacienteEncontrado.Latitud = paciente.Latitud;
                pacienteEncontrado.Longitud = paciente.Longitud;
                pacienteEncontrado.FechaNacimiento = paciente.FechaNacimiento;
/*                pacienteEncontrado.FamiliarDesignado = paciente.FamiliarDesignado;
                pacienteEncontrado.Medico = paciente.Medico;
                pacienteEncontrado.Enfermera = paciente.Enfermera;
                pacienteEncontrado.HistoriaClinica = paciente.HistoriaClinica;
                pacienteEncontrado.SignosVitales = paciente.SignosVitales;
*/
                _appContext.SaveChanges();
            }
            return pacienteEncontrado;
        }
    }
}