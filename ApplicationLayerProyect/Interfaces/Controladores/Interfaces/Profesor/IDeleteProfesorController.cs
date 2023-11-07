using ApplicationLayerProyect.Envoltorios.Profesores;

namespace ApplicationLayerProyect.Interfaces.Controladores.Interfaces.Profesor
{
    public interface IDeleteProfesorController
    {
        Task<EnvoltorioEliminarProfesor> EliminarProfesor(int IdAlumno);
    }
}
