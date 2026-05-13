using codice.Data;
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

namespace codice.Forms
{
    public partial class StudentView : Form
    {
        public StudentView()
        {
            InitializeComponent();
        }

        string rut = "";

        private void button2_Click(object sender, EventArgs e)
        {

            rut = inputRut.Text;
            Estudiante? Estudiante = EstudianteRepository.BuscarEstudiantePorRut(rut);

            if (Estudiante != null)
            {
                tableStudentInfo.Visible = true;

                DateTime hoy = DateTime.Now;

                int edad = hoy.Year - Estudiante.FechaNacimiento.Year;

                if (hoy < Estudiante.FechaNacimiento.AddYears(edad))
                {
                    edad--;
                }

                labelNombre.Text = Estudiante.Nombre;
                labelApellido.Text = Estudiante.Apellido;
                labelTelefono.Text = Estudiante.Telefono;
                labelCorreo.Text = Estudiante.Correo;
                labelEdad.Text = edad.ToString();
                labelCurso.Text = Estudiante.ObtenerNombreCurso();

            }
            else
            {
                MessageBox.Show($"No se encontraron estudiantes registrados con el RUT: {rut}");
            }

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StudentView_Load(object sender, EventArgs e)
        {
            tableStudentInfo.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            StudentForm frm = new StudentForm();

            Estudiante? Estudiante = EstudianteRepository.BuscarEstudiantePorRut(rut);

            if (Estudiante != null) { 
            
            frm.RenderView("editar", Estudiante.Rut);

            frm.ShowDialog();
            }

        }
    }
}
