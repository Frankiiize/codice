using codice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codice.Data
{
    internal class MockData
    {


        public void Initialize()
        {
            Usuario usuario = new Usuario();
            Docente docente = new Docente();

            int id = DocenteRepository.GenerarId();

            usuario.AgregarUsuario(id, "admin", "1234", "Docente");

            Asignatura programacion = new Asignatura();
            programacion.CrearAsignatura(1, "Programación", "PROG101");

            Asignatura baseDatos = new Asignatura();
            baseDatos.CrearAsignatura(2, "Base de Datos", "BD202");

            Curso curso1 = new Curso();
            curso1.CrearCurso(1, "Ingeniería en Informática", "Diurna");
            curso1.AgregarAsignatura(programacion);
            curso1.AgregarAsignatura(baseDatos);

            Curso curso2 = new Curso();
            curso2.CrearCurso(2, "Analista Programador", "Vespertina");
            curso2.AgregarAsignatura(programacion);

            docente.AsignarUsuario(usuario);
            docente.AgregarEspecialidad("Programación");

            docente.AgregarDocente(
                id,
                "26007476-8",
                "francisco",
                "jimenez",
                "964409213",
                usuario.Email,
                Convert.ToDateTime("1990-05-25")
            );

            docente.AgregarAsignatura(programacion);
            docente.AgregarAsignatura(baseDatos);

            docente.AgregarCurso(curso1);
            docente.AgregarCurso(curso2);

            DocenteRepository.Agregar(docente);
        }


        public void SeedCursos()
        {
            Asignatura programacion = new Asignatura();
            programacion.CrearAsignatura(1, "Programación", "PROG101");

            Asignatura programacion2 = new Asignatura();
            programacion2.CrearAsignatura(5, "Programación II", "PROG102");

            Asignatura baseDatos = new Asignatura();
            baseDatos.CrearAsignatura(2, "Base de Datos", "BD202");

            Asignatura redes = new Asignatura();
            redes.CrearAsignatura(3, "Redes", "RED303");

            Asignatura ciber = new Asignatura();
            ciber.CrearAsignatura(4, "Ciberseguridad", "CIB404");

            Curso curso1 = new Curso();
            curso1.CrearCurso(1, "Ingeniería en Informática", "Diurna");
            curso1.AgregarAsignatura(programacion);
            curso1.AgregarAsignatura(programacion2);
            curso1.AgregarAsignatura(baseDatos);

            Curso curso2 = new Curso();
            curso2.CrearCurso(2, "Analista Programador", "Vespertina");
            curso2.AgregarAsignatura(programacion);

            Curso curso3 = new Curso();
            curso3.CrearCurso(3, "Ingeniería en Redes", "Diurna");
            curso3.AgregarAsignatura(redes);

            Curso curso4 = new Curso();
            curso4.CrearCurso(4, "Ciberseguridad", "Vespertina");
            curso4.AgregarAsignatura(ciber);

            CursoRepository.Agregar(curso1);
            CursoRepository.Agregar(curso2);
            CursoRepository.Agregar(curso3);
            CursoRepository.Agregar(curso4);
        }

        public void SeedEstudianteDemo()
        {
            Curso? curso =  CursoRepository.ObtenerTodos().FirstOrDefault(c => c.ObtenerId() == 1);

            if (curso == null) return;

            Estudiante estudiante = new Estudiante();

            estudiante.AgregarEstudiante(
                EstudianteRepository.GenerarId(),
                "26007476-8",
                "Francisco",
                "Jimenez",
                "999999999",
                "francisco@codice.cl",
                Convert.ToDateTime("1990-05-25"),
                curso
            );

            foreach (Asignatura asignatura in curso.ObtenerAsignaturas())
            {
                estudiante.InscribirAsignatura(asignatura);
            }

            EstudianteRepository.Estudiantes.Add(estudiante);

            Asignatura? programacion =  curso.ObtenerAsignaturas().FirstOrDefault(a => a.ObtenerCodigo() == "PROG101");

            Asignatura? baseDatos =  curso.ObtenerAsignaturas().FirstOrDefault(a => a.ObtenerCodigo() == "BD202");

            if (programacion != null)
            {
                Calificacion nota1 = new Calificacion();

                nota1.RegistrarCalificacion(
                    CalificacionRepository.GenerarId(),
                    estudiante,
                    programacion,
                    6.5,
                    DateTime.Now.AddDays(-5),
                    "Prueba 1"
                );

                CalificacionRepository.Agregar(nota1);

                Calificacion nota2 = new Calificacion();

                nota2.RegistrarCalificacion(
                    CalificacionRepository.GenerarId(),
                    estudiante,
                    programacion,
                    5.8,
                    DateTime.Now.AddDays(-2),
                    "Taller"
                );

                CalificacionRepository.Agregar(nota2);

                Asistencia asistencia1 = new Asistencia();

                asistencia1.RegistrarAsistencia(
                    AsistenciaRepository.GenerarId(),
                    estudiante,
                    programacion,
                    DateTime.Now.AddDays(-5),
                    true
                );

                AsistenciaRepository.Agregar(asistencia1);

                Asistencia asistencia2 = new Asistencia();

                asistencia2.RegistrarAsistencia(
                    AsistenciaRepository.GenerarId(),
                    estudiante,
                    programacion,
                    DateTime.Now.AddDays(-2),
                    false
                );

                AsistenciaRepository.Agregar(asistencia2);
            }

            if (baseDatos != null)
            {
                Calificacion notaBd = new Calificacion();

                notaBd.RegistrarCalificacion(
                    CalificacionRepository.GenerarId(),
                    estudiante,
                    baseDatos,
                    6.0,
                    DateTime.Now.AddDays(-1),
                    "Control"
                );

                CalificacionRepository.Agregar(notaBd);

                Asistencia asistenciaBd = new Asistencia();

                asistenciaBd.RegistrarAsistencia(
                    AsistenciaRepository.GenerarId(),
                    estudiante,
                    baseDatos,
                    DateTime.Now.AddDays(-1),
                    true
                );

                AsistenciaRepository.Agregar(asistenciaBd);
            }
        }
    }
}
