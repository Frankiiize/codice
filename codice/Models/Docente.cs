using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codice.Models
{

    public class Docente : Persona
    {
        private string Especialidad { get; set; }

        private List<Asignatura> Asignaturas { get; set; }

        private List<Curso> Cursos { get; set; }

        private Usuario Usuario { get; set; }

        public Docente()
        {
            Especialidad = "";
            Asignaturas = new List<Asignatura>();
            Cursos = new List<Curso>();
            Usuario = new Usuario();
        }

        public bool AgregarDocente(int id,
                string rut,
                string nombre,
                string apellido,
                string telefono,
                string correo,
                DateTime fechaNacimiento)
        {
            this.Id = id;
            this.Rut = rut;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Telefono = telefono;
            this.Correo = correo;
            this.FechaNacimiento = fechaNacimiento;

            return true;

        }

        public bool AgregarEspecialidad(string especialidad) {
            
            this.Especialidad = especialidad;
            return true;
        
        }

        public void AgregarAsignatura(Asignatura asignatura)
        {
            Asignaturas.Add(asignatura);
        }

        public List<Asignatura> ObtenerAsignaturas()
        {
            return this.Asignaturas;
        }

        public void AsignarUsuario(Usuario usuario)
        {
            this.Usuario = usuario;
        }

        public Usuario ObtenerUsuario()
        {
            return this.Usuario;
        }

        public void AgregarCurso(Curso curso)
        {
            Cursos.Add(curso);
        }

        public List<Curso> ObtenerCursos()
        {
            return Cursos;
        }
     
        public string ObtenerEspecialidad ()
        {
            return this.Especialidad;
        }
    }
}
