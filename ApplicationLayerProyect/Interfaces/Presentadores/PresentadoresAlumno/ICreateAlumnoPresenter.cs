using ApplicationLayerProyect.Envoltorios.Alumnos;
using ApplicationLayerProyect.Interfaces.Getways.AlumnoGetways.OutputPortAlumno;

namespace ApplicationLayerProyect.Interfaces.Presentadores.PresentadoresAlumno
{
    public interface ICreateAlumnoPresenter : ICreateAlumnoOutputPort
    {

        EnvoltorioCrearAlumno Alumno { get; }
    }
}
