using System.Collections.Generic;
using HospiInHome.App.Dominio.Entidades;

namespace HospiInHome.App.Persistencia.AppRepositorios
{
    public interface IRepoPaciente
    {
        IEnumerable<Paciente> GetAllPacientes();
        Paciente AddPaciente(Paciente paciente);
        Paciente UpdatePaciente(Paciente paciente);
        void DeletePaciente(int idPaciente);
        Paciente GetPaciente(int idPaciente);
    }
}