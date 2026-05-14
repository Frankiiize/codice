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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace codice.Forms
{
    public partial class StudentForm : Form
    {
        private const string MODO_REGISTRAR = "registrar";
        private const string MODO_EDITAR = "editar";

        private string Modo { get; set; }

        private string? RutEstudiante { get; set; }

        public StudentForm()
        {
            Modo = MODO_REGISTRAR;
            RutEstudiante = null;

            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void RenderView(string modo, string? RutEstudiante)
        {
            this.Modo = modo;
            this.RutEstudiante = RutEstudiante;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (Modo == MODO_REGISTRAR)
            {
                string rut = inputRut.Text;
                string nombre = inputNombre.Text;
                string apellido = inputApellido.Text;
                string telefono = inputTelefono.Text;
                string correo = inputCorreo.Text;
                string fechaNacimiento = inputFechaNacimiento.Text;

                if (inputCursos.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un curso.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(inputRut.Text))
                {
                    MessageBox.Show("Rut Invalido.");
                    return;
                }
             

                Curso cursoSeleccionado = (Curso)inputCursos.SelectedItem;
                int id = EstudianteRepository.GenerarId();

                Estudiante es = new Estudiante();

                Estudiante? EstudianteExists = EstudianteRepository.BuscarEstudiantePorRut(rut);

                if (EstudianteExists == null)
                {
                    es.AgregarEstudiante(id, rut, nombre, apellido, telefono, correo, Convert.ToDateTime(fechaNacimiento), cursoSeleccionado);

                    EstudianteRepository.Estudiantes.Add(es);

                    List<Estudiante> lista = EstudianteRepository.Estudiantes;

                    string estudiantes = "";

                    foreach (Estudiante estudiante in lista)
                    {
                        estudiantes += estudiante.ObtenerDatos() + "\n";
                    }

                    MessageBox.Show("Estudiante Creado Con Exito \n" + estudiantes);
                }
                else
                {
                    MessageBox.Show("El estudiante ya existe.");
                }


            }

            if (Modo == MODO_EDITAR)
            {

                string rut = inputRut.Text;
                string nombre = inputNombre.Text;
                string apellido = inputApellido.Text;
                string telefono = inputTelefono.Text;
                string correo = inputCorreo.Text;
                string fechaNacimiento = inputFechaNacimiento.Text;


                if (inputCursos.SelectedItem == null)
                {
                    MessageBox.Show("Error al Cargar los cursos");
                    return;
                }
                Curso cursoSeleccionado = (Curso)inputCursos.SelectedItem;

                Estudiante? estudiante = EstudianteRepository.BuscarEstudiantePorRut(this.RutEstudiante);


                Estudiante es = new Estudiante();
                es.Rut = rut;
                es.Nombre = nombre;
                es.Apellido = apellido;
                es.Telefono = telefono;
                es.Correo = correo;
                es.FechaNacimiento = Convert.ToDateTime(fechaNacimiento);
                es.AgregarCurso(cursoSeleccionado);


                if (estudiante != null && estudiante.Rut.Length > 0)
                {
                    if (estudiante.ObtenerCurso().ObtenerId() != cursoSeleccionado.ObtenerId())
                    {
                        estudiante.LimpiarAsignaturasInscritas();
                    }

                    bool estudianteActualizado = EstudianteRepository.ActualizarEstudiante(estudiante.Rut, es);


                    if (estudianteActualizado)
                    {
                        MessageBox.Show("Estudiante actualizado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar el estudiante"); ;
                    }
                }
            }
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            MockData mockData = new MockData();

            mockData.SeedCursos();

            inputCursos.DataSource = CursoRepository.ObtenerTodos();

            if (Modo == MODO_REGISTRAR)
            {
                ActBtn.Text = "Registrar";
                labelTitle.Text = "Registro de Estudiantes";

            }

            if (Modo == MODO_EDITAR)
            {
                ActBtn.Text = "Editar";
                labelTitle.Text = "Edición de Estudiantes";



                if (this.RutEstudiante != null)
                {
                    Estudiante? estudiante = EstudianteRepository.BuscarEstudiantePorRut(RutEstudiante);

                    if (estudiante != null)
                    {
                        inputRut.Text = estudiante.Rut;
                        inputNombre.Text = estudiante.Nombre;
                        inputApellido.Text = estudiante.Apellido;
                        inputTelefono.Text = estudiante.Telefono;
                        inputCorreo.Text = estudiante.Correo;
                        inputFechaNacimiento.Value = estudiante.FechaNacimiento;
                        inputCursos.SelectedItem = CursoRepository.ObtenerTodos().FirstOrDefault(c => c.ObtenerNombre() == estudiante.ObtenerCurso().ObtenerNombre());
                    }
                }
            }
        }

    }
}
