README - Codice (Manual de usuario)

Resumen
-------
Aplicación de gestión académica en Windows Forms desarrollada en .NET 8. Permite administrar usuarios, docentes, cursos, asignaturas, estudiantes, calificaciones y asistencias.

Requisitos
---------
- Windows 10/11
- .NET SDK 8.0 instalado
- Microsoft Visual Studio 2022/2026 con soporte WinForms recomendado (o usar dotnet CLI para compilación)

Abrir y ejecutar la aplicación
-----------------------------
1. Abrir la solución: C:\Users\frank\source\repos\codice\codice.slnx en Visual Studio.
2. Establecer el proyecto "codice" como proyecto de inicio.
3. Compilar (Build > Build Solution) y ejecutar (F5 o Start).

Ejecutar desde línea de comandos
-------------------------------
- Compilar: dotnet build codice\codice.csproj
- Ejecutar: dotnet run --project codice\codice.csproj

Datos de demo y usuario de acceso
---------------------------------
El proyecto contiene datos de ejemplo en codice\Data\MockData.cs.
- Usuario por defecto de demo: usuario: "admin" contraseña: "1234" (rol: Docente).
Para cargar los datos de demo al iniciar la aplicación, llamar al inicializador (opcional):
- Abrir codigo\Program.cs y, antes de Application.Run(...), añadir: new codice.Data.MockData().Initialize();
(Descomentar o añadir según se desee cargar datos al arranque).

Flujo de uso (manual de usuario)
--------------------------------
1. Login
   - Introducir usuario y contraseña válidos. Si se usan datos de demo: admin / 1234.

2. Gestión de Docentes
   - Crear, editar y listar docentes.
   - Asignar cursos y asignaturas a docentes.

3. Gestión de Cursos
   - Crear cursos (id, nombre, jornada).
   - Asociar asignaturas a cada curso.

4. Gestión de Asignaturas
   - Crear y editar asignaturas (nombre, código).
   - Listar estudiantes inscritos por asignatura.

5. Gestión de Estudiantes
   - Crear estudiantes en un curso.
   - Inscribir asignaturas, editar datos personales.

6. Calificaciones
   - Registrar calificaciones: id, estudiante, asignatura, nota, fecha, evaluación (descripción).
   - Consultar notas y obtener historial por estudiante/asignatura.

7. Asistencias
   - Registrar asistencias por estudiante y asignatura (fecha, presente/ausente).
   - Consultar historiales de asistencia.

Repositorios y almacenamiento
-----------------------------
- La aplicación usa clases Repository en carpeta codice\Data para almacenar datos en memoria (Mock/Repository pattern).
- Para persistencia real, implementar repositorios que guarden en base de datos (no incluido).

Proyecto de pruebas
-------------------
- Proyecto de tests unitarios: codigo.test.
- Ejecutar tests: dotnet test codice.test\codice.test.csproj o desde Test Explorer en Visual Studio.

Configuración y ajustes
-----------------------
- Target framework del proyecto principal: net8.0-windows.
- Ajustes de compilación y uso de WinForms están en codice\codice.csproj.

Buenas prácticas y notas para usuarios
-------------------------------------
- Antes de añadir datos en producción, validar formatos de RUT, correo y fechas.
- Las entidades principales (Estudiante, Docente, Curso, Asignatura) exponen métodos para crear/actualizar; seguir esos métodos para mantener consistencia.
- Para añadir persistencia, crear implementaciones de los repositorios y reemplazar las listas en memoria.

Solución de problemas comunes
-----------------------------
- Error al compilar por incompatibilidad de TargetFramework: asegurar que el proyecto de tests use net8.0-windows para referenciar el proyecto principal.
- Tests no encuentran tipos internos: hacer las clases públicas o exponer internals mediante InternalsVisibleTo si se requiere.
- Si no ve datos de demo: activar la llamada a MockData.Initialize() en Program.cs o usar las funciones de carga manual en la UI.

Contacto y contribuciones
-------------------------
- Repositorio: https://github.com/Frankiiize/codice
- Para contribuir: abrir issues o pull requests con descripciones claras de cambios.

Licencia
--------
Incluye código de ejemplo; añadir licencia al repositorio si se va a compartir públicamente.

Fin del manual
--------------
Si se desea, puedo generar una versión más corta para usuarios finales o una guía técnica para desarrolladores (arquitectura, patrón repository, lista de clases y APIs internas).