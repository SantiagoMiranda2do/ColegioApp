using ApplicationLayerProyect.Envoltorios.Profesores;

namespace ApplicationLayerProyect.Interfaces.Getways.ProfesorGetways.OutputPortProfesor
{
    public interface IUpdateProfesorOutputPort
    {

        Task handle(EnvoltorioActualizarProfesor Profesor);
    }
}
