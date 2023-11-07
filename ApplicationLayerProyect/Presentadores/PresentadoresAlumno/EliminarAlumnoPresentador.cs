using ApplicationLayerProyect.Envoltorios.Alumnos;
using ApplicationLayerProyect.Interfaces.Presentadores.PresentadoresAlumno;

namespace ApplicationLayerProyect.Presentadores.PresentadoresAlumno
{
    public class EliminarAlumnoPresentador : IDeleteAlumnoPresenter
    {
        public EnvoltorioEliminarAlumno Alumno { get; private set; } = new EnvoltorioEliminarAlumno();

        public Task handle(EnvoltorioEliminarAlumno Alumno)
        {
            Alumno.NumeroError = Alumno.NumeroError;
            Alumno.Mensaje = Alumno.Mensaje;
            Alumno.IdAlumno = Alumno.IdAlumno;
            return Task.CompletedTask;
        }
    }
}
