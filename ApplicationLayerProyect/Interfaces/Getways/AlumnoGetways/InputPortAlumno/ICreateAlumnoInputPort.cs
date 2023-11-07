using DomainLayerProject.DTOs.Request.RequestAlumno;

namespace ApplicationLayerProyect.Interfaces.Getways.AlumnoGetways.InputPortAlumno
{
    public interface ICreateAlumnoInputPort
    {
        Task Handle(CrearAlumnoRequest crearAlumnoRequest);
    }
}
