using ApplicationLayerProyect.Envoltorios.Profesores;

namespace ApplicationLayerProyect.Interfaces.Getways.ProfesorGetways.OutputPortProfesor
{
    public interface ICreateProfesorOutputPort
    {
        Task Handle(EnvoltorioCrearProfesor profesor);
    }
}
