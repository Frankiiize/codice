using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codice.Models
{
    internal class Calificacion
    {
        private int Id { get; set; }

        private Estudiante Estudiante { get; set; }

        private Asignatura Asignatura { get; set; }

        private double Nota { get; set; }

        private DateTime Fecha { get; set; }

        private string Evaluacion { get; set; }

        public Calificacion()
        {
            Estudiante = new Estudiante();
            Asignatura = new Asignatura();
            Nota = 0;
            Fecha = DateTime.Now;
            Evaluacion = "";
        }

        public bool RegistrarCalificacion(
            int id,
            Estudiante estudiante,
            Asignatura asignatura,
            double nota,
            DateTime fecha,
            string evaluacion)
        {
            Id = id;
            Estudiante = estudiante;
            Asignatura = asignatura;
            Nota = nota;
            Fecha = fecha;
            Evaluacion = evaluacion;

            return true;
        }

        public int ObtenerId()
        {
            return Id;
        }

        public Estudiante ObtenerEstudiante()
        {
            return Estudiante;
        }

        public Asignatura ObtenerAsignatura()
        {
            return Asignatura;
        }

        public double ObtenerNota()
        {
            return Nota;
        }

        public DateTime ObtenerFecha()
        {
            return Fecha;
        }

        public string ObtenerEvaluacion()
        {
            return Evaluacion;
        }
    }
}
