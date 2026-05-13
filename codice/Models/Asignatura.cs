using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codice.Models
{

    public class Asignatura
    {
        private int Id { get; set; }

        private string Nombre { get; set; }

        private string Codigo { get; set; }

        public Asignatura()
        {
            Nombre = "";
            Codigo = "";
        }

        public string ObtenerCodigo()
        {
            return Codigo;
        }

        public bool CrearAsignatura(int id,string nombre, string codigo)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Codigo = codigo;

            return true;
        }

        public bool EditarAsignatura(string nombre, string codigo)
        {
            return true;
        }
        public List<Estudiante> ListarEstudiantes()
        {
            return [];
        }
    }
}
