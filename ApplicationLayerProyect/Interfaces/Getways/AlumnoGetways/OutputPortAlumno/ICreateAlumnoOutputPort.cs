using ApplicationLayerProyect.Envoltorios.Alumnos;

namespace ApplicationLayerProyect.Interfaces.Getways.AlumnoGetways.OutputPortAlumno
{
    public interface ICreateAlumnoOutputPort
    {

        Task Handle(EnvoltorioCrearAlumno alumno);
    }
}
