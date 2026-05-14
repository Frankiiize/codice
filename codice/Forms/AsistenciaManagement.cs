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
    public partial class AsistenciaManagement : Form
    {
        public AsistenciaManagement()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void GoRegistrar_Click(object sender, EventArgs e)
        {
            AsistenciaAddForm frm = new AsistenciaAddForm();

            frm.ShowDialog();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
