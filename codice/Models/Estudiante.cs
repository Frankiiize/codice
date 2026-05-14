using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codice.Models
{
    public class Estudiante : Persona
    {


        private Curso Curso { get; set; }

        private List<Asignatura> AsignaturasInscritas { get; set; }

        public Estudiante()
        {
            Curso = new Curso();
            AsignaturasInscritas = new List<Asignatura>();
        }

        public bool AgregarEstudiante(int id,
            string rut,
            string nombre,
            string apellido,
            string telefono,
            string correo,
            DateTime fechaNacimiento,
            Curso curso)
        {
            this.Id = id;
            this.Rut = rut;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Telefono = telefono;
            this.Correo = correo;
            this.FechaNacimiento = fechaNacimiento;
            this.Curso = curso;

            return true;
           
        }

        public bool ActualizarEstudiante(
            string rut,
            string nombre,
            string apellido,
            string telefono,
            string correo,
            DateTime fechaNacimiento,
            Curso curso
           )
        {
            bool actualizo = this.Actualizar(
              rut,
              nombre,
              apellido,
              telefono,
              correo,
              fechaNacimiento);

            this.AgregarCurso(curso);

      

            return actualizo;

        }

        public String ObtenerNombreCurso()
        {
            return this.Curso.ObtenerNombre();
        }

        public void AgregarCurso(Curso curso)
        {
            this.Curso = curso;
        }

        public Curso ObtenerCurso()
        {
            return this.Curso;
        }

        public void InscribirAsignatura(Asignatura asignatura)
        {
            AsignaturasInscritas.Add(asignatura);
        }

        public List<Asignatura> ObtenerAsignaturasInscritas()
        {
            return AsignaturasInscritas;
        }
        public void LimpiarAsignaturasInscritas()
        {
            AsignaturasInscritas.Clear();
        }
        public void EliminarAsignatura(int id)
        {
            var asignatura = AsignaturasInscritas.FirstOrDefault(a => a.ObtenerId() == id);
            if (asignatura != null)
            {
                AsignaturasInscritas.Remove(asignatura);
            }
        }

        public double CalcularPromedio()
        {
            return 0;
        }
    }
}
