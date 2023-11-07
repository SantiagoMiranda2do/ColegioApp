using ApplicationLayerProyect.Envoltorios.Profesores;

namespace ApplicationLayerProyect.Interfaces.Getways.ProfesorGetways.OutputPortProfesor
{
    public interface IDeleteProfesorOutputPort
    {
        Task Handle(EnvoltorioEliminarProfesor profesor);
    }
}
