using codice.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace codice
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        public void button1_Click(object sender, EventArgs e)
        {
            string email = inputEmail.Text;
            string password = inputPassword.Text;

            bool EsValido = DocenteRepository.ValidarAcceso(email, password);

            if(!EsValido)
            {
                MessageBox.Show("Usuario o Contraseñas incorrectos.");
            } else
            {
                this.Hide();

                Home home = new Home();
                home.ShowDialog();

                this.Show();
            }
;


        }

        private void Login_Load(object sender, EventArgs e)
        {
            MockData initMockData = new MockData();

            initMockData.Initialize();
        }
    }
}
