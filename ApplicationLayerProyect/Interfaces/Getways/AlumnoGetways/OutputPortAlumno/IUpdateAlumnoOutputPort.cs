using ApplicationLayerProyect.Envoltorios.Alumnos;

namespace ApplicationLayerProyect.Interfaces.Getways.AlumnoGetways.OutputPortAlumno
{
    public interface IUpdateAlumnoOutputPort
    {
        Task handle(EnvoltorioActualizarAlumno alumno);
    }
}
