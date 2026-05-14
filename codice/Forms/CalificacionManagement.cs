using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace codice.Forms
{
    public partial class CalificacionManagement : Form
    {
        public CalificacionManagement()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void GoAgregarCalificacion_Click(object sender, EventArgs e)
        {
            CalificacionAddForm frm = new CalificacionAddForm();


            this.Hide();

            frm.ShowDialog();

            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalificacionHistory frm = new CalificacionHistory();


            this.Hide();

            frm.ShowDialog();

            this.Show();
        }
    }
}
