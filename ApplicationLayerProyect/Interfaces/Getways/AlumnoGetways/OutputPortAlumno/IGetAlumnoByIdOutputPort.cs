using ApplicationLayerProyect.Envoltorios.Alumnos;

namespace ApplicationLayerProyect.Interfaces.Getways.AlumnoGetways.OutputPortAlumno
{
    public interface IGetAlumnoByIdOutputPort
    {

        Task handle(EnvoltorioSeleccionarAlumno alumno);
    }
}
