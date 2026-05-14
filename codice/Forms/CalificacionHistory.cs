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
    public partial class CalificacionHistory : Form
    {
        public CalificacionHistory()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string rut = inputRut.Text;

            Estudiante? estudiante =  EstudianteRepository.BuscarEstudiantePorRut(rut);

            if (estudiante == null)
            {
                dataGridCalificaciones.Visible = false;

                dataGridCalificaciones.Columns.Clear();
                dataGridCalificaciones.Rows.Clear();

                MessageBox.Show("Estudiante no encontrado.");
                return;
            }
            dataGridCalificaciones.Visible = true;
            dataGridCalificaciones.Columns.Clear();
            dataGridCalificaciones.Rows.Clear();

            dataGridCalificaciones.Columns.Add("Asignatura", "Asignatura");
            dataGridCalificaciones.Columns.Add("Evaluacion", "Evaluación");
            dataGridCalificaciones.Columns.Add("Fecha", "Fecha");
            dataGridCalificaciones.Columns.Add("Nota", "Nota");

            foreach (Calificacion calificacion in CalificacionRepository.Calificaciones)
            {
                if (calificacion.ObtenerEstudiante().Rut == estudiante.Rut)
                {
                    dataGridCalificaciones.Rows.Add(
                        calificacion.ObtenerAsignatura().ObtenerNombre(),
                        calificacion.ObtenerEvaluacion(),
                        calificacion.ObtenerFecha().ToShortDateString(),
                        calificacion.ObtenerNota()
                    );
                }
            }

            dataGridCalificaciones.Visible = dataGridCalificaciones.Rows.Count > 0;

            if (dataGridCalificaciones.Rows.Count == 0)
            {
                MessageBox.Show("No hay calificaciones registradas para este estudiante.");
            }
        }

        private void CalificacionHistory_Load(object sender, EventArgs e)
        {
            dataGridCalificaciones.Visible = false;
            dataGridCalificaciones.ReadOnly = false;
        }
    }
}
