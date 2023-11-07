using ApplicationLayerProyect.Envoltorios.Alumnos;
using ApplicationLayerProyect.Interfaces.Getways.AlumnoGetways.OutputPortAlumno;

namespace ApplicationLayerProyect.Interfaces.Presentadores.PresentadoresAlumno
{
    public interface IUpdateAlumnoPresenter : IUpdateAlumnoOutputPort
    {

        EnvoltorioActualizarAlumno Alumno { get; }
    }
}
