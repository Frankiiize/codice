using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codice.Models
{
    public class Asistencia
    {
        private int Id { get; set; }
        private Estudiante Estudiante { get; set; }

        private Asignatura Asignatura { get; set; }

        private DateTime Fecha { get; set; }

        private bool Presente { get; set; }

        public Asistencia()
        {
            Estudiante = new Estudiante();
            Asignatura = new Asignatura();
            Fecha = DateTime.Now;
            Presente = false;
        }

        public bool RegistrarAsistencia(int id,  Estudiante estudiante, Asignatura asignatura, DateTime fecha, bool presente)
        {
            Id = id;
            Estudiante = estudiante;
            Asignatura = asignatura;
            Fecha = fecha;
            Presente = presente;

            return true;
        }

    }
}
