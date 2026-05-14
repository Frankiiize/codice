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
    public partial class AsistenciaHistory : Form
    {
        public AsistenciaHistory()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        bool seEncontraronRegistros = false;

        private void AsistenciaHistory_Load(object sender, EventArgs e)
        {
            dataGridEstudiantes.AllowUserToAddRows = false;
            dataGridEstudiantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridEstudiantes.ReadOnly = true;
            dataGridEstudiantes.Visible = false;

            Docente? docente = DocenteRepository.ObtenerDocenteLogueado();

            if (docente != null)
            {
                foreach (Curso curso in docente.ObtenerCursos())
                {
                    comboBoxCursos.Items.Add(curso);
                }
            }
        }

        private void comboBoxCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboboxAsignaturas.Items.Clear();
            comboboxAsignaturas.SelectedIndex = -1;
            comboboxAsignaturas.Text = "Seleccione una asignatura";
            inputFechaAsistencia.Value = DateTime.Now;

            dataGridEstudiantes.Visible = false;
            dataGridEstudiantes.Columns.Clear();
            dataGridEstudiantes.Rows.Clear();

            Curso? curso = comboBoxCursos.SelectedItem as Curso;

            if (curso == null) return;

            foreach (Asignatura asignatura in curso.ObtenerAsignaturas())
            {
                comboboxAsignaturas.Items.Add(asignatura);
            }

        }

        private void CargarHistorial()
        {
            Curso? curso = comboBoxCursos.SelectedItem as Curso;
            Asignatura? asignatura = comboboxAsignaturas.SelectedItem as Asignatura;

            if (curso == null || asignatura == null) return;

            DateTime fecha = inputFechaAsistencia.Value.Date;

            dataGridEstudiantes.Visible = false;
            dataGridEstudiantes.Columns.Clear();
            dataGridEstudiantes.Rows.Clear();


            dataGridEstudiantes.Columns.Add("Rut", "RUT");
            dataGridEstudiantes.Columns.Add("Nombre", "Nombre");
            dataGridEstudiantes.Columns.Add("Apellido", "Apellido");

            DataGridViewCheckBoxColumn presenteColumn = new DataGridViewCheckBoxColumn();
            presenteColumn.Name = "Presente";
            presenteColumn.HeaderText = "Presente";
            dataGridEstudiantes.Columns.Add(presenteColumn);

            foreach (Estudiante estudiante in EstudianteRepository.ObtenerTodosLosEstudiantes())
            {
                if (estudiante.ObtenerCurso().ObtenerId() != curso.ObtenerId()) continue;

                Asistencia? asistencia = AsistenciaRepository.Asistencias
                    .FirstOrDefault(a =>
                        a.ObtenerEstudiante().Rut == estudiante.Rut &&
                        a.ObtenerAsignatura().ObtenerId() == asignatura.ObtenerId() &&
                        a.ObtenerFecha().Date == fecha
                    );
                if (asistencia != null) {

                    seEncontraronRegistros = true;

                    dataGridEstudiantes.Rows.Add(
                          estudiante.Rut,
                          estudiante.Nombre,
                          estudiante.Apellido,
                          asistencia != null && asistencia.ObtenerPresente()
                      );

                }
            }

            if (seEncontraronRegistros)
            {
                dataGridEstudiantes.Visible = true;
            }
            else
            {
                dataGridEstudiantes.Visible = false;

                MessageBox.Show(
                    "No se encontraron registros de asistencia.",
                    "Sin resultados",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void comboboxAsignaturas_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarHistorial();
        }

        private void inputFechaAsistencia_ValueChanged(object sender, EventArgs e)
        {
            CargarHistorial();
        }
    }
}
