using System.Collections;
using System.Collections.Generic;
using HospiInHome.App.Dominio.Entidades;

namespace HospiInHome.App.Persistencia.AppRepositorios
{
    public interface IRepoEnfermera
    {
        Enfermera AddEnfermera(Enfermera enfermera);
        /* void DeleteEnfermera(int idEnfermera);
        Enfermera UpdateEnfermera(Enfermera enfermera);
        Enfermera GetEnfermera(int idEnfermera);
        IEnumerable<Enfermera> GetAllEnfermeras(); */
    }
}