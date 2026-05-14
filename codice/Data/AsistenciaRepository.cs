using codice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codice.Data
{
    internal class AsistenciaRepository
    {

        public static List<Asistencia> Asistencias = new List<Asistencia>();

        private static int siguienteId = 1;

        public static int GenerarId()
        {
            return siguienteId++;
        }

        public static void Agregar(Asistencia asistencia)
        {
            Asistencias.Add(asistencia);
        }
    }
}
