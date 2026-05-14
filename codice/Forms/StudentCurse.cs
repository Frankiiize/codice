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
    public partial class StudentCurse : Form
    {
        public StudentCurse()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        string rut = "";



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(rut))
            {
                Estudiante? EstudianteExists = EstudianteRepository.BuscarEstudiantePorRut(rut);

                if (EstudianteExists != null)
                {
                    EstudianteExists.LimpiarAsignaturasInscritas();

                    string asignaturasAgregadas = "Asignaturas seleccionadas:\n\n";

                    foreach (Asignatura asignatura in listAsignatura.CheckedItems)
                    {
                        EstudianteExists.InscribirAsignatura(asignatura);
                        asignaturasAgregadas += $"- {asignatura.ObtenerNombre()} ({asignatura.ObtenerCodigo()})\n";
                    }

                    MessageBox.Show(asignaturasAgregadas);

                   

                }
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBuscarEstudiante_1(object sender, EventArgs e)
        {
            rut = inputRut.Text;

            if (string.IsNullOrWhiteSpace(inputRut.Text))
            {
                MessageBox.Show("Rut Invalido.");
                return;
            }


            Estudiante? EstudianteExists = EstudianteRepository.BuscarEstudiantePorRut(rut);


            if (EstudianteExists != null)
            {
                Curso EstudianteCurso = EstudianteExists.ObtenerCurso();

                List<Asignatura> EstudianteAsig = EstudianteExists.ObtenerAsignaturasInscritas();

                int CursoID = EstudianteCurso.ObtenerId();


                Curso? Curso = CursoRepository.BuscarPorId(CursoID);

                if (Curso != null)
                {
                    List<Asignatura> AsignaturasCurso = Curso.ObtenerAsignaturas();

                    listAsignatura.Items.Clear();

                    foreach (Asignatura asignatura in AsignaturasCurso)
                    {
                        listAsignatura.Items.Add(asignatura);
                    }
                    for (int i = 0; i < listAsignatura.Items.Count; i++)
                    {
                        Asignatura asignaturaLista =
                            (Asignatura)listAsignatura.Items[i];

                        bool inscrita = EstudianteAsig.Any(a =>
                            a.ObtenerId() == asignaturaLista.ObtenerId());

                        listAsignatura.SetItemChecked(i, inscrita);
                    }
                }

                labelAsignatura.Text = $"Curso: {EstudianteExists.ObtenerNombreCurso()}";

                labelNombre.Text = $"Estudiante: {EstudianteExists.Nombre} {EstudianteExists.Apellido}";
            }
            else
            {
                MessageBox.Show("Estudiante no encontrado");
                return;
            }
        }

     
    }
}
