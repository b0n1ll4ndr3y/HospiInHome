using System;
using HospiInHome.App.Dominio.Entidades;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HospiInHome.App.Persistencia.AppRepositorios
{
    public class RepoFamiliar : IRepoFamiliar
    {
        private readonly AppContext _appContext;

        public RepoFamiliar(AppContext appContext)
        {
            this._appContext = appContext;
        }

        FamiliarDesignado IRepoFamiliar.AddFamiliarDesignado(FamiliarDesignado familiarDesignado)
        {
            var familiarAgregado = _appContext.familiaresDesignados.Add(familiarDesignado);
            _appContext.SaveChanges();
            return familiarAgregado.Entity;
        }
        FamiliarDesignado IRepoFamiliar.GetFamiliarDesignado(int idFamiliarDesignado)
        {
            return _appContext.familiaresDesignados.FirstOrDefault(p => p.Id == idFamiliarDesignado);
        }
        public IEnumerable<FamiliarDesignado> GetAllFamiliaresDesignados()
        {
            return _appContext.familiaresDesignados;
        }
        public void DeleteFamiliarDesignado(int idFamiliarDesignado)
        {
            var familiarEncontrado = _appContext.familiaresDesignados.FirstOrDefault(p => p.Id == idFamiliarDesignado);
            if (familiarEncontrado == null)
            {
                return;
            }
            _appContext.familiaresDesignados.Remove(familiarEncontrado);
            _appContext.SaveChanges();
        }
        public FamiliarDesignado UpdateFamiliarDesignado(FamiliarDesignado familiarDesignado)
        {
            var familiarEncontrado = _appContext.familiaresDesignados.FirstOrDefault(p => p.Id == familiarDesignado.Id);
            if (familiarEncontrado != null)
            {
                familiarEncontrado.Nombre = familiarDesignado.Nombre;
                familiarEncontrado.Apellido = familiarDesignado.Apellido;
                familiarEncontrado.TipoDocumento = familiarDesignado.TipoDocumento;
                familiarEncontrado.Documento = familiarDesignado.Documento;
                familiarEncontrado.Genero = familiarDesignado.Genero;
                familiarEncontrado.Parentesco = familiarDesignado.Parentesco;
                familiarEncontrado.Correo = familiarDesignado.Correo;
                _appContext.SaveChanges();
            }
            return familiarEncontrado;
        }
    }
}