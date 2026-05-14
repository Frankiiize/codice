using codice.Data;
using codice.Models;
using codice.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace codice.Forms
{
    public partial class CalificacionAddForm : Form
    {
        public CalificacionAddForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void CalificacionAddForm_Load(object sender, EventArgs e)
        {
            inputFechaCalificacion.Format = DateTimePickerFormat.Short;
            inputAsignatura.Items.Clear();
            inputAsignatura.Items.Add("Seleccionar Asignatura");
            inputAsignatura.SelectedIndex = 0;
            inputAsignatura.DropDownStyle = ComboBoxStyle.DropDownList;

            Validations.Validate.IsActiveBtnStyle(ActBtn, !string.IsNullOrWhiteSpace(inputRut.Text));
        }

        string rut = "";

        private void button1_Click(object sender, EventArgs e)
        {
            rut = inputRut.Text;

            Estudiante? Estudiante = EstudianteRepository.BuscarEstudiantePorRut(rut);

            Dictionary<string, string?> fields = new()
                {
                    { "Rut", inputRut.Text },
                };


            bool valid = Validations.Validate.InputsValidate(fields);

            if (!valid) return; 


            if (Estudiante == null)
            {
                MessageBox.Show("Estudiante no encontrado.");
                return;
            }


            if (Estudiante != null)
            {

                Validations.Validate.IsActiveBtnStyle(ActBtn, true);

                List<Asignatura> asignaturas = Estudiante.ObtenerAsignaturasInscritas();

                inputAsignatura.Items.Clear();
                labelNombre.Text = $"Nombre: {Estudiante.Nombre} {Estudiante.Apellido}";
                labelCurso.Text = $"Curso: {Estudiante.ObtenerNombreCurso()}";


                foreach (Asignatura asignatura in asignaturas)
                {
                    inputAsignatura.Items.Add(asignatura);
                }
            }

        }

        private void ActBtn_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(rut)) {
                Estudiante? Estudiante = EstudianteRepository.BuscarEstudiantePorRut(rut);

                if (Estudiante != null)
                {
                    Asignatura? asignaturaSeleccionada = inputAsignatura.SelectedItem as Asignatura;


                    Dictionary<string, string?> fields = new()
                        {
                            { "Asignatura", asignaturaSeleccionada?.ToString() == "Seleccionar Asignatura" ? "" :  asignaturaSeleccionada?.ToString() },
                            { "Evaluacion", inputEvaluacion.Text },
                            { "Nota", inputNota.Text },
                        };


                    if (asignaturaSeleccionada == null) return;


                    bool valid = Validations.Validate.InputsValidate(fields);

                    if (!valid) return;

                    Calificacion calificacion = new Calificacion();

                    calificacion.RegistrarCalificacion(
                        CalificacionRepository.GenerarId(),
                        Estudiante,
                        asignaturaSeleccionada,
                        double.Parse(inputNota.Text),
                        inputFechaCalificacion.Value,
                        inputEvaluacion.Text
                    );

                    CalificacionRepository.Agregar(calificacion);

                    inputNota.Text = "";
                    inputFechaCalificacion.Text = "";
                    inputEvaluacion.Text = "";

                    MessageBox.Show("Calificación registrada correctamente.");
                }
            }
        }
    }
}
