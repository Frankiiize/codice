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
    public partial class StudentCurseView : Form
    {

        private string? RutEstudiante { get; set; }


        public StudentCurseView()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            RutEstudiante = null;
        }

        public void RenderView(string? RutEstudiante)
        {
            this.RutEstudiante = RutEstudiante;
        }

        private void StudentCurseView_Load(object sender, EventArgs e)
        {
            Estudiante? estudiante = EstudianteRepository.BuscarEstudiantePorRut(RutEstudiante);

            dataListAsignaturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataListAsignaturas.ReadOnly = true;

            if (estudiante != null)
            {
                Curso cursoEstudiante = estudiante.ObtenerCurso();

                dataListAsignaturas.Rows.Clear();
                dataListAsignaturas.Columns.Clear();

                dataListAsignaturas.Columns.Add("Id", "ID");
                dataListAsignaturas.Columns.Add("Nombre", "Nombre");
                dataListAsignaturas.Columns.Add("Codigo", "Código");


                foreach (Asignatura asignatura in estudiante.ObtenerAsignaturasInscritas())
                {
                    dataListAsignaturas.Rows.Add(
                        asignatura.ObtenerId(),
                        asignatura.ObtenerNombre(),
                        asignatura.ObtenerCodigo()
                    );
                }
            }
            else
            {
                MessageBox.Show("No se encontró el estudiante con el RUT proporcionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataListAsignaturas.SelectedRows.Count == 0) return;

            var row = dataListAsignaturas.SelectedRows[0];

            if (row.IsNewRow) return;

            var idCell = row.Cells["Id"].Value;
            if (idCell == null) return;

            if (!int.TryParse(idCell.ToString(), out int idAsignatura)) return;

            Estudiante? estudiante = EstudianteRepository.BuscarEstudiantePorRut(RutEstudiante);
            if (estudiante == null) return;

            estudiante.EliminarAsignatura(idAsignatura);

            dataListAsignaturas.Rows.RemoveAt(row.Index);
        }
    }
}
