using System.Collections.Generic;
using System.Linq;
using HospiInHome.App.Dominio.Entidades;

namespace HospiInHome.App.Persistencia.AppRepositorios
{
    public interface IRepoMedico
    {
        IEnumerable<Medico> GetAllMedicos();
        /* IEnumerable<Medico> GetAllMedicosEspecialidad(); */
        Medico AddMedico(Medico medico);
        void DeleteMedico(int idMedico);
        Medico UpdateMedico(Medico medico);
        Medico GetMedico(int idMedico);
    }
}