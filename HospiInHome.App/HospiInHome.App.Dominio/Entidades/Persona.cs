using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace HospiInHome.App.Dominio.Entidades
{
    public class Persona
    {
        public int Id {get; set;}
        [Required, StringLength(50)]
        public string Nombre {get; set;}
        [Required, StringLength(50)]
        public string Apellido {get; set;}
        [EnumDataType(typeof(TipoDocumento))]
        public TipoDocumento TipoDocumento {get; set;}
        [Required, StringLength(15)]
        public string Documento {get; set;}
        public Genero Genero {get; set;}
    }

    public enum TipoDocumento
    {
        [Description("Cedula de Ciudadanía")]
        CedulaDeCiudadania = 0,
        [Description("Pasaporte")]
        Pasaporte = 1,
        [Description("Tarjeta de Identidad")]
        TarjetaDeIdentidad = 2,
        [Description("Cédula de Extranjería")]
        CedulaDeExtranjeria = 3
    }

    public enum Genero
    {
        Masculino,
        Femenino,
        Bisexual,
        Intersexual,
        Pansexual,
        Transexual
    }

}