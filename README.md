# Manual de Usuario y Técnico Básico  

# Sistema Académico Códice

# 1. Descripción General

Sistema Académico Códice es una aplicación de escritorio desarrollada en C# utilizando Windows Forms y .NET 8. El sistema tiene como objetivo apoyar la gestión académica del Instituto Técnico Profesional Códice, permitiendo administrar estudiantes, cursos, asignaturas, asistencias y calificaciones.

La aplicación fue desarrollada aplicando Programación Orientada a Objetos (POO), utilizando clases, herencia, encapsulamiento y repositorios en memoria para gestionar la información.

---

# 2. Objetivo del Sistema

Digitalizar el proceso académico del instituto mediante una aplicación que permita:

- Registrar y editar estudiantes.
- Inscribir asignaturas.
- Registrar asistencias.
- Registrar calificaciones.
- Consultar historial académico.
- Visualizar promedios por asignatura.

---

# 3. Requisitos del Sistema

## Software requerido

- Windows 10 o Windows 11.
- .NET SDK 8.0 instalado.
- Visual Studio 2022 o superior.
- Soporte para Windows Forms.

## Framework utilizado
net8.0-windows

## Datos de demo y usuario de acceso
---------------------------------
El proyecto contiene datos de ejemplo en codice\Data\MockData.cs.
- Usuario por defecto de demo: usuario: "admin" contraseña: "1234" (rol: Docente).
- Estudiante por defecto de demo: Francisco Jimenez, Rut: 26007476-8

# Funcionalidades Principales

- Inicio de Sesión
   Permite validar el acceso de docentes mediante usuario y contraseña.

### Gestión de Estudiantes

Permite:

   - Registrar estudiantes.
   - Editar estudiantes.
   - Asociar estudiantes a cursos.
   - Visualizar información académica.
   - Consultar asignaturas inscritas.

### Inscripción de Asignaturas

- Inscribir asignaturas a estudiantes.
- Visualizar asignaturas disponibles según el curso.
- Eliminar asignaturas inscritas.
- Visualizar promedio por asignatura.

### Gestión de Asistencias

Permite:

- Registrar asistencia por:
   - curso
   - asignatura
   - fecha
- Marcar estudiantes como presentes o ausentes.
- Consultar historial de asistencia.

### Gestión de Calificaciones

Permite:

- Registrar notas.
- Asociar evaluaciones a asignaturas.
- Consultar historial de calificaciones.
- Calcular promedio por asignatura.

# Flujo de Uso

### Login
- Usuario: admin
- Contraseña: 1234

### Gestión Académica

Desde el menú principal se puede acceder a:

- Gestión de estudiantes.
- Gestión de asistencia.
- Gestión de calificaciones.

### Registro de Estudiante

- Ingresar datos personales.
- Seleccionar curso.
- Guardar estudiante.

### Inscripción de Asignaturas

- Buscar estudiante por RUT.
- Seleccionar asignaturas.
- Confirmar inscripción.

### Inscripción de Asignaturas

- Seleccionar curso.
- Seleccionar asignatura.
- Seleccionar fecha.
- Marcar estudiantes presentes.
- Confirmar asistencia.

### Registro de Calificaciones

- Buscar estudiante.
- Seleccionar asignatura.
- Ingresar evaluación.
- Ingresar nota.
- Registrar calificación.

# Arquitectura del Proyecto

```bash
codice/
├── Data/
├── Forms/
├── Models/
├── Validations/
├── Program.cs
└── codice.csproj
```


# Descripción de Carpetas

### Data

Contiene repositorios y datos mock:

- EstudianteRepository
- CursoRepository
- DocenteRepository
- AsistenciaRepository
- CalificacionRepository
- MockData

### Models

Contiene las entidades principales del sistema:

- Persona
- Usuario
- Docente
- Estudiante
- Curso
- Asignatura
- Asistencia
- Calificacion

### Forms

Contiene las ventanas del sistema:

- Login
- Home
- StudentForm
- StudentView
- StudentCurse
- StudentCurseView
- AsistenciaAddForm
- AsistenciaHistory
- CalificacionAddForm
- CalificacionHistory

### Validations

Contiene validaciones reutilizables para formularios.