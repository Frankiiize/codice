using codice.Data;
using codice.Forms;
using codice.Models;
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
    public partial class studentsManagement : Form
    {
        public studentsManagement()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            StudentView frm = new StudentView();

            frm.ShowDialog();
        }

        private void GoRegistrar_Click(object sender, EventArgs e)
        {
            StudentForm frm = new StudentForm();

            frm.RenderView("registrar", null);

            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentCurse frm = new StudentCurse();

            frm.ShowDialog();

        }
    }
}
