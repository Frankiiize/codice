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
    public partial class AsistenciaAddForm : Form
    {
        public AsistenciaAddForm()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void AsistenciaAddForm_Load(object sender, EventArgs e)
        {
            dataGridEstudiantes.AllowUserToAddRows = false;
            dataGridEstudiantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
         

            inputFechaAsistencia.Format = DateTimePickerFormat.Short;

            Docente? docente = DocenteRepository.ObtenerDocenteLogueado();

            if (docente != null)
            {
                foreach (Curso curso in docente.ObtenerCursos())
                {
                    comboBoxCursos.Items.Add(curso);
                }
            }

        }

        private void comboboxAsignaturas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboboxAsignaturas.SelectedItem == null)
                return;

            Asignatura asignaturaSeleccionada =
                (Asignatura)comboboxAsignaturas.SelectedItem;

            int idAsignatura = asignaturaSeleccionada.ObtenerId();

            dataGridEstudiantes.Columns.Clear();
            dataGridEstudiantes.Rows.Clear();
            inputFechaAsistencia.Value = DateTime.Now;

            dataGridEstudiantes.Columns.Add("Rut", "RUT");
            dataGridEstudiantes.Columns.Add("Nombre", "Nombre");
            dataGridEstudiantes.Columns.Add("Apellido", "Apellido");

            DataGridViewCheckBoxColumn asistenciaColumn =
                new DataGridViewCheckBoxColumn();

            asistenciaColumn.Name = "Presente";
            asistenciaColumn.HeaderText = "Presente";

            dataGridEstudiantes.Columns.Add(asistenciaColumn);

            foreach (Estudiante estudiante in EstudianteRepository.ObtenerTodosLosEstudiantes())
            {
                bool tieneAsignatura = estudiante.ObtenerAsignaturasInscritas().Any(a => a.ObtenerId() == idAsignatura);

                if (tieneAsignatura)
                {
                    dataGridEstudiantes.Rows.Add(
                        estudiante.Rut,
                        estudiante.Nombre,
                        estudiante.Apellido,
                        false
                    );
                }
            }
        }

        private void comboBoxCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Curso? cursoSeleccionado = comboBoxCursos.SelectedItem as Curso;

            comboboxAsignaturas.Items.Clear();
            comboboxAsignaturas.SelectedIndex = -1;
            comboboxAsignaturas.Text = "Seleccione una asignatura";
            inputFechaAsistencia.Value = DateTime.Now;

            if (cursoSeleccionado == null) return;

            Docente? docente = DocenteRepository.ObtenerDocenteLogueado();

            if (docente == null) return;

            comboboxAsignaturas.Items.Clear();

            List<Asignatura> asignaturasDocente = docente.ObtenerAsignaturas();

            foreach (Asignatura asignaturaCurso in cursoSeleccionado.ObtenerAsignaturas())
            {
                bool docenteTieneAsignatura = asignaturasDocente.Any(a => a.ObtenerId() == asignaturaCurso.ObtenerId());

                if (docenteTieneAsignatura)
                {
                    comboboxAsignaturas.Items.Add(asignaturaCurso);
                }
            }
        }

        private void ActBtn_Click(object sender, EventArgs e)
        {
            if (comboboxAsignaturas.SelectedItem == null) return;

            Asignatura asignaturaSeleccionada =  (Asignatura)comboboxAsignaturas.SelectedItem;

            foreach (DataGridViewRow fila in dataGridEstudiantes.Rows)
            {

                string rut =  fila.Cells["Rut"].Value.ToString() ?? "";

                bool presente =  Convert.ToBoolean(fila.Cells["Presente"].Value);

                DateTime fecha = inputFechaAsistencia.Value;

                Estudiante? estudiante = EstudianteRepository.BuscarEstudiantePorRut(rut);

                if (estudiante != null)
                {
                    Asistencia asistencia = new Asistencia();

                    asistencia.RegistrarAsistencia(
                        AsistenciaRepository.GenerarId(),
                        estudiante,
                        asignaturaSeleccionada,
                        fecha,
                        presente
                    );

                    AsistenciaRepository.Agregar(asistencia);
                }
            }

            MessageBox.Show("Asistencia registrada correctamente");
        }
    }
}
