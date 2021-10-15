using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using HospiInHome.App.Dominio.Entidades;

namespace HospiInHome.App.Persistencia.AppRepositorios
{
    public class RepoEnfermera : IRepoEnfermera
    {
        private readonly AppContext _appContext;

        public RepoEnfermera(AppContext appContext)
        {
            _appContext = appContext;
        }

        Enfermera IRepoEnfermera.AddEnfermera(Enfermera enfermera)
        {
            var enfermeraAgregada = _appContext.Enfermeras.Add(enfermera);
            _appContext.SaveChanges();
            return enfermeraAgregada.Entity;
        }
    }
}