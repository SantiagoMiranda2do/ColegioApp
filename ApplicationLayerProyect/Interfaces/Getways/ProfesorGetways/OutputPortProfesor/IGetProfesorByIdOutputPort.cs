using ApplicationLayerProyect.Envoltorios.Profesores;

namespace ApplicationLayerProyect.Interfaces.Getways.ProfesorGetways.OutputPortProfesor
{
    public interface IGetProfesorByIdOutputPort
    {
        Task handle(EnvoltorioSeleccionarProfesor profesor);
    }
}
