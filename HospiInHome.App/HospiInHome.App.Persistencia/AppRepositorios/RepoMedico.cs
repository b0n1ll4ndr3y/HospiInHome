using System.Collections;
using System.Collections.Generic;
using System.Linq;
using HospiInHome.App.Dominio.Entidades;

namespace HospiInHome.App.Persistencia.AppRepositorios
{
    public class RepoMedico : IRepoMedico
    {
        private readonly AppContext _appContext;

        public RepoMedico(AppContext appContext)
        {
            _appContext = appContext;
        }

        Medico IRepoMedico.AddMedico(Medico medico)
        {
            var medicoAdicionado = _appContext.medicos.Add(medico);
            _appContext.SaveChanges();
            return medicoAdicionado.Entity;
        }

        void IRepoMedico.DeleteMedico(int idMedico)
        {
            var medicoEncontrado = _appContext.medicos.FirstOrDefault(p => p.Id == idMedico);
            if (medicoEncontrado == null)
                return;
            _appContext.medicos.Remove(medicoEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Medico> IRepoMedico.GetAllMedicos()
        {
            return _appContext.medicos;
        }

        Medico IRepoMedico.GetMedico(int idMedico)
        {
            return _appContext.medicos.FirstOrDefault(p => p.Id == idMedico);
        }

        /* IEnumerable<Medico> IRepoMedico.GetAllMedicosEspecialidad()
        {
            return _appContext.medicos.Where(p => p.Especialidad == Especialidad.Id).ToList();
        } */

        Medico IRepoMedico.UpdateMedico(Medico medico)
        {
            var medicoEncontrado = _appContext.medicos.FirstOrDefault(p => p.Id == medico.Id);
            if (medicoEncontrado != null)
            {
                medicoEncontrado.Nombre = medico.Nombre;
                medicoEncontrado.Apellido = medico.Apellido;
                medicoEncontrado.TipoDocumento = medico.TipoDocumento;
                medicoEncontrado.Documento = medico.Documento;
                medicoEncontrado.Genero = medico.Genero;

                medicoEncontrado.Especialidad = medico.Especialidad;
                medicoEncontrado.RegistroMedico = medico.RegistroMedico;

                _appContext.SaveChanges();
            }
            return medicoEncontrado;
        }
    }
}