using ApplicationLayerProyect.Envoltorios.Alumnos;

namespace ApplicationLayerProyect.Interfaces.Getways.AlumnoGetways.OutputPortAlumno
{
    public interface IDeleteAlumnoOutputPort
    {

        Task handle(EnvoltorioEliminarAlumno Alumno);
    }
}
