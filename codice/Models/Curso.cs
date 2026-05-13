using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codice.Models
{

    public class Curso
    {
        private int Id { get; set; }
        private string Nombre { get; set; }
        private string Jornada { get; set; }

        private List<Asignatura> Asignaturas { get; set; }


        public Curso()
        {
            Nombre = "";
            Jornada = "";
            Asignaturas = new List<Asignatura>();
        }

        public bool CrearCurso(int id, string nombre, string jornada)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Jornada = jornada;

            return true;
        }

        public void AgregarAsignatura(Asignatura asignatura)
        {
            Asignaturas.Add(asignatura);
        }

        public List<Asignatura> ObtenerAsignaturas()
        {
            return Asignaturas;
        }

        public int ObtenerId()
        {
            return Id;
        }
        public string ObtenerNombre()
        {
            return Nombre;
        }

        public string ObtenerJornada()
        {
            return Jornada;
        }

        public override string ToString()
        {
            return Nombre;
        }

    }
}
