using ApplicationLayerProyect.Envoltorios.Alumnos;
using ApplicationLayerProyect.Interfaces.Presentadores.PresentadoresAlumno;
using DomainLayerProject.Entidades;

namespace ApplicationLayerProyect.Presentadores.PresentadoresAlumno
{
    public class ObtenerTodosAlumnosPresentador : IGetAllAlumnosPresenter
    {
        public EnvoltorioSeleccionarTodosAlumnos Alumno { get; private set; }

        public ValueTask Handle(EnvoltorioSeleccionarTodosAlumnos alumnos)
        {

            //foreach (var alumno in Alumnos)
            //{
            //    Alumnos.Append(new EnvoltorioSeleccionarAlumno
            //    {
            //        IdAlumno = alumno.IdActor,
            //        NombreAlumno = alumno.NombreActor,
            //        NumeroError = alumno.ErrorNumber,
            //        Mensaje = string.IsNullOrEmpty(alumno.Message) ? "" : alumno.Message

            //    });
            //}
            Alumnos = alumnos;
            return ValueTask.CompletedTask;
        }
    }
}