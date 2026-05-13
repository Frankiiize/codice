using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codice.Models
{

    public class Usuario
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Rol { get; set; }

        public Usuario()
        {
            Email ="";
            Password = "";
            Rol = "";
        }

        public void AgregarUsuario(int id, string email, string Password, string Rol)
        {
            this.Id = id;
            this.Email = email;
            this.Password = Password;
            this.Rol = Rol;
        }

    }
}
