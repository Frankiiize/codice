using codice.Forms;
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
    public partial class AcademicManagement : Form
    {
        public AcademicManagement()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void GoRegistrar_Click(object sender, EventArgs e)
        {
            AsistenciaManagement frm = new AsistenciaManagement();

            frm.ShowDialog();

            this.Hide();
        }
    }
}
