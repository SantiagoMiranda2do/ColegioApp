using ApplicationLayerProyect.Envoltorios.Alumnos;

namespace ApplicationLayerProyect.Interfaces.Controladores.Interfaces.Alumno
{
    public interface IDeleteAlumnoController
    {

        Task<EnvoltorioEliminarAlumno> EliminarAlumno(int IdActor);
    }
}
