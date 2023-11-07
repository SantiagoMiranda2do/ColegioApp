using DomainLayerProject.DTOs.Request.RequestAlumno;

namespace ApplicationLayerProyect.Interfaces.Getways.AlumnoGetways.InputPortAlumno
{
    public interface IUpdateAlumnoInputPort
    {
        Task Handle(ActualizarAlumnoRequest updateAlumnoRequest);
    }
}
