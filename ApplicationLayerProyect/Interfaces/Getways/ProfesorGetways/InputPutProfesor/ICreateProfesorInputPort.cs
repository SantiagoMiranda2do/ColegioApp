using DomainLayerProject.DTOs.Request.RequestProfesor;

namespace ApplicationLayerProyect.Interfaces.Getways.ProfesorGetways.InputPutProfesor
{
    public interface ICreateProfesorInputPort
    {

        Task Handle(CrearProfesorRequest crearProfesorRequest);
    }
}
