using Microsoft.VisualStudio.TestTools.UnitTesting;
using codice.Models;

namespace codice.test
{
    [TestClass]
    public class EstudianteTests
    {
        [TestMethod]
        public void AgregarEstudiante_DeberiaAsignarNombreCorrectamente()
        {
            Curso curso = new Curso();
            curso.CrearCurso(1, "Ingeniería", "Diurna");

            Estudiante estudiante = new Estudiante();

            estudiante.AgregarEstudiante(
                1,
                "12345678-9",
                "Francisco",
                "Jimenez",
                "999999999",
                "correo@test.com",
                DateTime.Now,
                curso
            );

            Assert.AreEqual("Francisco", estudiante.Nombre);
        }

        [TestMethod]
        public void RegistrarAsistencia_DeberiaGuardarPresenteCorrectamente()
        {
            Curso curso = new Curso();
            curso.CrearCurso(1, "Ingeniería en Informática", "Diurna");

            Estudiante estudiante = new Estudiante();
            estudiante.AgregarEstudiante(
                1,
                "12345678-9",
                "Francisco",
                "Jimenez",
                "999999999",
                "correo@test.com",
                DateTime.Now,
                curso
            );

            Asignatura asignatura = new Asignatura();
            asignatura.CrearAsignatura(1, "Programación", "PROG101");

            Asistencia asistencia = new Asistencia();

            asistencia.RegistrarAsistencia(
                1,
                estudiante,
                asignatura,
                DateTime.Now,
                true
            );

            Assert.IsTrue(asistencia.ObtenerPresente());
            Assert.AreEqual("Francisco", asistencia.ObtenerEstudiante().Nombre);
            Assert.AreEqual("Programación", asistencia.ObtenerAsignatura().ObtenerNombre());
        }

        [TestMethod]
        public void RegistrarCalificacion_DeberiaGuardarNotaCorrectamente()
        {
            Curso curso = new Curso();
            curso.CrearCurso(1, "Ingeniería en Informática", "Diurna");

            Estudiante estudiante = new Estudiante();
            estudiante.AgregarEstudiante(
                1,
                "12345678-9",
                "Francisco",
                "Jimenez",
                "999999999",
                "correo@test.com",
                DateTime.Now,
                curso
            );

            Asignatura asignatura = new Asignatura();
            asignatura.CrearAsignatura(1, "Base de Datos", "BD202");

            Calificacion calificacion = new Calificacion();

            calificacion.RegistrarCalificacion(
                1,
                estudiante,
                asignatura,
                6.5,
                DateTime.Now,
                "Prueba 1"
            );

            Assert.AreEqual(6.5, calificacion.ObtenerNota());
            Assert.AreEqual("Prueba 1", calificacion.ObtenerEvaluacion());
        }
    }
}