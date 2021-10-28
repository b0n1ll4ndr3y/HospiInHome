using HospiInHome.App.Dominio.Entidades;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HospiInHome.App.Persistencia.AppRepositorios
{
    public interface IRepoFamiliar
    {
        FamiliarDesignado AddFamiliarDesignado(FamiliarDesignado FamiliarDesignado);
        FamiliarDesignado GetFamiliarDesignado(int idFamiliarDesignado);
        IEnumerable<FamiliarDesignado> GetAllFamiliaresDesignados();
        void DeleteFamiliarDesignado(int idFamiliarDesignado);
        FamiliarDesignado UpdateFamiliarDesignado(FamiliarDesignado FamiliarDesignado);
    }
}