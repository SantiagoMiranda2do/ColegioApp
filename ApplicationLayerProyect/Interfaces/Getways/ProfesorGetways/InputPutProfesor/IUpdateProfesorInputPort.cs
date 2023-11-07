using DomainLayerProject.DTOs.Request.RequestProfesor;

namespace ApplicationLayerProyect.Interfaces.Getways.ProfesorGetways.InputPutProfesor
{
    public interface IUpdateProfesorInputPort
    {
        Task Handle(ActualizarProfesorRequest updateProfesorRequest);
    }
}
