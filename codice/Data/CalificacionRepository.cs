using codice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codice.Data
{
    internal class CalificacionRepository
    {
        public static List<Calificacion> Calificaciones = new List<Calificacion>();

        private static int siguienteId = 1;

        public static int GenerarId()
        {
            return siguienteId++;
        }

        public static void Agregar(Calificacion calificacion)
        {
            Calificaciones.Add(calificacion);
        }
    }
}
