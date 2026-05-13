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

            usuario.AgregarUsuario( id, "admin@email.com", "1234", "Docente");

            List<Asignatura> asignaturas = new List<Asignatura>();

            Asignatura asignatura1 = new Asignatura();
            asignatura1.CrearAsignatura(1, "Programacion", "PROG101");

            Asignatura asignatura2 = new Asignatura();
            asignatura2.CrearAsignatura(1, "Base de Datos", "BD202");

            asignaturas.Add(asignatura1);
            asignaturas.Add(asignatura2);


            docente.AsignarUsuario(usuario);

            docente.AgregarEspecialidad("Programación");

            docente.AgregarDocente(id, "26007476-8", "francisco", "jimenez", "964409213", usuario.Email, Convert.ToDateTime("1990-05-25"));

            for (int i = 0; i < asignaturas.Count; i++)
            {
                Asignatura asignatura = asignaturas[i];
                docente.AgregarAsignatura(asignatura);
            }

            DocenteRepository.Agregar(docente);




        }

        public void SeedCursos()
        {
            Asignatura prog = new Asignatura();
            prog.CrearAsignatura(1, "Programación", "PROG101");

            Asignatura bd = new Asignatura();
            bd.CrearAsignatura(2, "Base de Datos", "BD202");

            Asignatura redes = new Asignatura();
            redes.CrearAsignatura(3, "Redes", "RED303");

            Asignatura ciber = new Asignatura();
            ciber.CrearAsignatura(4, "Ciberseguridad", "CIB404");


            Curso curso1 = new Curso();
            curso1.CrearCurso(1, "Ingeniería en Informática", "Diurna");

            Curso curso2 = new Curso();
            curso2.CrearCurso(2, "Analista Programador", "Vespertina");

            Curso curso3 = new Curso();
            curso3.CrearCurso(3, "Ingeniería en Redes", "Diurna");

            Curso curso4 = new Curso();
            curso4.CrearCurso(4, "Ciberseguridad", "Vespertina");


            curso1.AgregarAsignatura(prog);
            curso1.AgregarAsignatura(bd);

            curso2.AgregarAsignatura(prog);

            curso3.AgregarAsignatura(redes);

            curso4.AgregarAsignatura(ciber);


            CursoRepository.Agregar(curso1);
            CursoRepository.Agregar(curso2);
            CursoRepository.Agregar(curso3);
            CursoRepository.Agregar(curso4);
        }
    }
}
