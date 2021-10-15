using System;
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

        /* private static void AddPaciente()
        {
            var paciente = new Paciente
            {
                Console.Write("Nombres: ");
                Nombre = Console.ReadLine();

                Console.Write("Apellidos: ");
                Apellido = Console.ReadLine();
                Console.Write("Telefono: ");
                Telefono = Console.ReadLine();
                Genero = Genero.Masculino;
                TipoDocumento = TipoDocumento.CedulaDeCiudadania;
                Console.Write("Documento: ");
                Documento = Console.ReadLine();
                Console.Write("Latitud: ");
                Latitud = Console.ReadLine();
                Console.Write("Logitud: ");
                Longitud = Console.ReadLine();
                FechaNacimiento = new DateTime(1993, 02, 08)
            };
            _repoPaciente.AddPaciente(paciente);
            Console.WriteLine("El Paciente, " + paciente.Nombre + " " + paciente.Apellido + " fué agregado con éxito!");
        } */

/* CRUD de PACIENTE */
        private static void AddPaciente()
        {
            var paciente = new Paciente
            {
                Nombre = "Michel",
                Apellido = "Prada",
                Telefono = "3067387544",
                Genero = Genero.Femenino,
                TipoDocumento = TipoDocumento.CedulaDeCiudadania,
                Documento = "1002581637",
                Latitud = 6.0233284D,
                Longitud = -43.68673D,
                PlanMedico = "Contributivo",
                FechaNacimiento = new DateTime(1999, 05, 08)
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
