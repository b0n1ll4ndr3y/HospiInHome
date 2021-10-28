using System.Collections;
using System.Collections.Generic;
using HospiInHome.App.Dominio.Entidades;

namespace HospiInHome.App.Persistencia.AppRepositorios
{
    public interface IRepoPaciente
    {
        IEnumerable<Paciente> GetAllPacientes();
        /* IEnumerable<Paciente> GetAll(); */
        Paciente AddPaciente(Paciente paciente);
        Paciente UpdatePaciente(Paciente paciente);
        void DeletePaciente(int idPaciente);
        Paciente GetPaciente(int idPaciente);
        FamiliarDesignado GetFamiliarDesignado(int idPaciente);
        /* IEnumerable<FamiliarDesignado> GetFamiliarDesignado(); */
        Medico GetMedicoAsignado(int idPaciente);
        Enfermera GetEnfermeraAsignada(int idPaciente);
        /* IEnumerable<Paciente> GetFamiliarDesignado(); */
    }
}