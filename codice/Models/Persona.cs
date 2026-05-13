using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace codice.Models
{
    public class Persona
    {
        public int Id { get; set; }

        public string Rut { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Telefono { get; set; }

        public string Correo { get; set; }

        public DateTime FechaNacimiento { get; set; }

        // Constructor vacío
        public Persona()
        {
            Rut = "";
            Nombre = "";
            Apellido = "";
            Telefono = "";
            Correo = "";
        }

        // Constructor con parámetros
        public Persona(
            int id,
            string rut,
            string nombre,
            string apellido,
            string telefono,
            string correo,
            DateTime fechaNacimiento)
        {
            Id = id;
            Rut = rut;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Correo = correo;
            FechaNacimiento = fechaNacimiento;
        }

        public string ObtenerDatos()
        {
            return $"Nombre: {Nombre} {Apellido} - Rut: {Rut}";
        }

        public bool Actualizar(
            string rut,
            string nombre,
            string apellido,
            string telefono,
            string correo,
            DateTime fechaNacimiento)
        {
            bool modificacion = false;

            if (!string.IsNullOrWhiteSpace(rut))
            {
                Rut = rut;
                modificacion = true;
            }


            if (!string.IsNullOrWhiteSpace(nombre))
            {
                Nombre = nombre;
                modificacion = true;
            }

            if (!string.IsNullOrWhiteSpace(apellido))
            {
                Apellido = apellido;
                modificacion = true;
            }

            if (!string.IsNullOrWhiteSpace(telefono))
            {
                Telefono = telefono;
                modificacion = true;
            }

            if (!string.IsNullOrWhiteSpace(correo))
            {
                Correo = correo;
                modificacion = true;
            }

            if (fechaNacimiento != DateTime.MinValue)
            {
                FechaNacimiento = fechaNacimiento;
                modificacion = true;
            }

            return modificacion;
        }
    }
}
