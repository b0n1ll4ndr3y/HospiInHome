using System;
using System.Collections.Generic;
using HospiInHome.App.Dominio.Entidades;
using HospiInHome.App.Persistencia.AppRepositorios;

namespace HospiInHome.App.Consola
{
    class Program
    {
        private static IRepoPaciente _repoPaciente = new RepoPaciente(new Persistencia.AppContext());
        private static IRepoMedico _repoMedico = new RepoMedico(new Persistencia.AppContext());
        private static IRepoEnfermera _repoEnfermera = new RepoEnfermera(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("\n####################################################");
            Console.WriteLine("#                    TuringSoft                    #");
            Console.WriteLine("#         Proyecto Hospitalización en Casa         #");
            Console.WriteLine("# Implementación Base de Datos - Entity Framework  #");
            Console.WriteLine("####################################################\n");

            /* CRUD de PACIENTE */
            AddPaciente();
            //BuscarPaciente(2);
            //BorrarPaciente(2);
            //AsignarMedico();

            /* CRUD de MEDICO */
            //AddMedico();

            /* CRUD de ENFERMERA */
            //AddEnfermera();
        }

/* CRUD de PACIENTE */
        private static void AddPaciente()
        {
            var paciente = new Paciente
            {
                Nombre = "Andrea",
                Apellido = "Gomez",
                Telefono = "3147381234",
                Genero = Genero.Femenino,
                TipoDocumento = TipoDocumento.CedulaDeCiudadania,
                Documento = "1071231637",
                Latitud = 6.0299284D,
                Longitud = -43.60873D,
                PlanMedico = "Contibutivo",
                FechaNacimiento = new DateTime(2000, 05, 20),
                FamiliarDesignado = new FamiliarDesignado {
                    Nombre = "Luis",
                    Apellido = "Gomez",
                    TipoDocumento = TipoDocumento.CedulaDeCiudadania,
                    Documento = "1073785412",
                    Genero = Genero.Masculino,
                    Parentesco = "Hermano",
                    Correo = "luisHermano@correo.com"
                },
                SignosVitales = new List<SignoVital> {
                    new SignoVital{FechaHora= new DateTime(2021,10,07,22,30,08), TipoSigno=TipoSigno.Oximetria, Valor=94},
                    new SignoVital{FechaHora= new DateTime(2021,10,07,22,30,08), TipoSigno=TipoSigno.FrecuenciaRespiratoria, Valor=53},
                    new SignoVital{FechaHora= new DateTime(2021,10,07,22,30,08), TipoSigno=TipoSigno.FrecuenciaCardiaca, Valor=67},
                    new SignoVital{FechaHora= new DateTime(2021,10,07,22,30,08), TipoSigno=TipoSigno.Temperatura, Valor=33},
                    new SignoVital{FechaHora= new DateTime(2021,10,07,22,30,08), TipoSigno=TipoSigno.PresionArterial, Valor=125},
                    new SignoVital{FechaHora= new DateTime(2021,10,07,22,30,08), TipoSigno=TipoSigno.Glicemia, Valor=108}
                }
            };
            _repoPaciente.AddPaciente(paciente);
            Console.WriteLine("Paciente, " + paciente.Nombre + " " + paciente.Apellido + " ha sido agregad@ exitosamente!\n");
        }

        private static void BuscarPaciente(int idPaciente)
        {
            var paciente = _repoPaciente.GetPaciente(idPaciente);
            Console.WriteLine("***PACIENTE No." + paciente.Id + "***");
            Console.WriteLine("Paciente: " + paciente.Nombre + " " + paciente.Apellido);
            Console.WriteLine("Teléfono: " + paciente.Telefono + "\nGénero: " + paciente.Genero);
            Console.WriteLine("Identificación: " + paciente.TipoDocumento + " " + paciente.Documento);
            Console.WriteLine("Geolocalización: (Latitud: " + paciente.Latitud + ", Longitud: " + paciente.Longitud + ")");
            Console.WriteLine("Fecha de Nacimiento: " + paciente.FechaNacimiento +"\n");
        }

        private static void BorrarPaciente(int idPaciente)
        {
            _repoPaciente.DeletePaciente(idPaciente);
            Console.WriteLine("Paciente con ID:" + idPaciente + " eliminado con exito!\n");
        }

/* CRUD de MEDICO */
        public static void AddMedico()
        {
            var medico = new Medico()
            {
                Nombre = "Sara",
                Apellido = "Molina",
                TipoDocumento = TipoDocumento.CedulaDeCiudadania,
                Documento = "1002581637",
                Genero = Genero.Femenino,

                Especialidad = "Interista",
                RegistroMedico = "RM-193745"
            };
            _repoMedico.AddMedico(medico);
            Console.WriteLine("Medico " + medico.Nombre + " " + medico.Apellido + " ha sido agregad@ exitosamente!\n");
        }

/* CRUD de ENFERMERA */
        public static void AddEnfermera()
        {
            var enfermera = new Enfermera
            {
                Nombre = "Daisy",
                Apellido = "Fuentes",
                TipoDocumento = TipoDocumento.TarjetaDeIdentidad,
                Documento = "TI-73623523",
                Genero = Genero.Femenino,

                TarjetaProfesional = "TP-82376346234",
                HorasLaborales = "40"
            };
            _repoEnfermera.AddEnfermera(enfermera);
            Console.WriteLine("Enfermera " + enfermera.Nombre + " " + enfermera.Apellido + " ha sido agregada exitosamente!\n");

        }
    }
}
