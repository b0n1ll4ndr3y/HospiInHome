using System.Collections;
using System.Collections.Generic;
using System.Linq;
using HospiInHome.App.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace HospiInHome.App.Persistencia.AppRepositorios
{
    public class RepoPaciente : IRepoPaciente
    {
        private readonly AppContext _appContext;

        public RepoPaciente(AppContext appContext)
        {
            this._appContext=appContext;
        }

        public IEnumerable<Paciente> GetAllPacientes()
        {
            return _appContext.Pacientes;
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

        Paciente IRepoPaciente.GetPaciente(int idPaciente)
        {
            return _appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
        }

        FamiliarDesignado IRepoPaciente.GetFamiliarDesignado(int idPaciente)
        {
            var familiarDesignado = _appContext.Pacientes.Where(s => s.Id == idPaciente).Include(s => s.FamiliarDesignado).FirstOrDefault();
            return familiarDesignado.FamiliarDesignado;
        }
        /* IEnumerable<FamiliarDesignado> IRepoPaciente.GetFamiliarDesignado()
        {
            return _appContext.Pacientes.Where(f => f.FamiliarDesignado == idFamiliarDesignado).ToList();
        } */


        Medico IRepoPaciente.GetMedicoAsignado(int idPaciente)
        {
            var medico = _appContext.Pacientes.Where(s => s.Id == idPaciente).Include(s => s.Medico).FirstOrDefault();
            return medico.Medico;
        }

        Enfermera IRepoPaciente.GetEnfermeraAsignada(int idPaciente)
        {
            var enfermera = _appContext.Pacientes.Where(s => s.Id == idPaciente).Include(s => s.Enfermera).FirstOrDefault();
            return enfermera.Enfermera;
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
                pacienteEncontrado.SignosVitales = paciente.SignosVitales;
                pacienteEncontrado.FamiliarDesignado = paciente.FamiliarDesignado;
                pacienteEncontrado.Medico = paciente.Medico;
                pacienteEncontrado.Enfermera = paciente.Enfermera;
                pacienteEncontrado.HistoriaClinica = paciente.HistoriaClinica;
                _appContext.SaveChanges();
            }
            return pacienteEncontrado;
        }
    }
}