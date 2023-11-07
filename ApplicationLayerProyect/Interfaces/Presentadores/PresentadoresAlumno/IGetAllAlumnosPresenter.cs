using ApplicationLayerProyect.Envoltorios.Alumnos;
using ApplicationLayerProyect.Interfaces.Getways.AlumnoGetways.OutputPortAlumno;

namespace ApplicationLayerProyect.Interfaces.Presentadores.PresentadoresAlumno
{
    public interface IGetAllAlumnosPresenter : IGetAllAlumnosOutputPort
    {

        EnvoltorioSeleccionarTodosAlumnos Alumno { get; }
    }
}
