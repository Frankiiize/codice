using codice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codice.Data
{
    public static class DocenteRepository
    {
        public static List<Docente> Docentes = new List<Docente>();

        private static int siguienteId = 1;

        public static int GenerarId()
        {
            return siguienteId++;
        }

        public static void Agregar(Docente docente)
        {
            Docentes.Add(docente);
        }

        public static Docente? BuscarPorUsuario(string email, string password)
        {
            return Docentes.FirstOrDefault(d =>
            {
                Usuario usuario = d.ObtenerUsuario();

                return usuario.Email == email &&
                       usuario.Password == password;
            });
        }

        public static bool ValidarAcceso(string email, string password)
        {
            return BuscarPorUsuario(email, password) != null;
        }

    
        public static Docente? BuscarDocentePorRut(string rut)
        {
            return Docentes.FirstOrDefault(d => d.Rut == rut);
        }

    }
}
