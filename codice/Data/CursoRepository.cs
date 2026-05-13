using codice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codice.Data
{
    public static class CursoRepository
    {
        public static List<Curso> Cursos = new List<Curso>();

        private static int siguienteId = 1;

        public static int GenerarId()
        {
            return siguienteId++;
        }

        public static void Agregar(Curso curso)
        {
            Cursos.Add(curso);
        }

        public static List<Curso> ObtenerTodos()
        {
            return Cursos;
        }

        public static Curso? BuscarPorId(int id)
        {
            return Cursos.FirstOrDefault(c => c.ObtenerId() == id);
        }

    }
}
