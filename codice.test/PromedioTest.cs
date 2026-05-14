using codice.Data;
using codice.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace codice.test
{
    internal class PromedioTest
    {
        public class PromedioTests
        {
            [TestMethod]
            public void CalcularPromedioAsignatura_DeberiaRetornarPromedioCorrecto()
            {
                CalificacionRepository.Calificaciones.Clear();

                Curso curso = new Curso();
                curso.CrearCurso(1, "Ingeniería en Informática", "Diurna");

                Asignatura asignatura = new Asignatura();
                asignatura.CrearAsignatura(1, "Programación", "PROG101");

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

                Calificacion nota1 = new Calificacion();
                nota1.RegistrarCalificacion(
                    1,
                    estudiante,
                    asignatura,
                    5.0,
                    DateTime.Now,
                    "Prueba 1"
                );

                Calificacion nota2 = new Calificacion();
                nota2.RegistrarCalificacion(
                    2,
                    estudiante,
                    asignatura,
                    7.0,
                    DateTime.Now,
                    "Prueba 2"
                );

                CalificacionRepository.Agregar(nota1);
                CalificacionRepository.Agregar(nota2);

                double promedio =
                    estudiante.CalcularPromedioAsignatura(asignatura);

                Assert.AreEqual(6.0, promedio);
            }
        }
    }
}
