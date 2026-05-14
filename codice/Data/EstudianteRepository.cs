using codice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codice.Data
{
    public static class EstudianteRepository
    {
        public static List<Estudiante> Estudiantes = new List<Estudiante>();

        private static int siguienteId = 1;

        public static int GenerarId()
        {
            return siguienteId++;
        }


        public static Estudiante? BuscarEstudiantePorRut(string? rut)
        {
            return Estudiantes.FirstOrDefault(e => e.Rut == rut);
        }

        public static bool ActualizarEstudiante(string rutOriginal, Estudiante estudianteActualizado)
        {
            Estudiante? estudiante = BuscarEstudiantePorRut(rutOriginal);

            if (estudiante == null)
            {
                return false;
            }

            return estudiante.ActualizarEstudiante(
                estudianteActualizado.Rut,
                estudianteActualizado.Nombre,
                estudianteActualizado.Apellido,
                estudianteActualizado.Telefono,
                estudianteActualizado.Correo,
                estudianteActualizado.FechaNacimiento,
                estudianteActualizado.ObtenerCurso()
            );
        }

        public static List<Estudiante> ObtenerTodosLosEstudiantes()
        {
            return Estudiantes;
        }

    }
}