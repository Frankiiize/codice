using codice.Data;
using codice.Forms;
using codice.Models;

namespace codice
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            studentsManagement Studentfrm = new studentsManagement();


            this.Hide();

            Studentfrm.ShowDialog();

            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AcademicManagement academicFrm = new AcademicManagement();

            this.Hide();

            academicFrm.ShowDialog();

            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            DocenteRepository.CerrarSesion();
        }
    }
}
