using ApplicationLayerProyect.Envoltorios.Profesores;
using DomainLayerProject.DTOs.Request.RequestProfesor;

namespace ApplicationLayerProyect.Interfaces.Controladores.Interfaces.Profesor
{
    public interface IUpdateProfesorController
    {
        Task<EnvoltorioActualizarProfesor> ActualizarProfesor(ActualizarProfesorRequest request);
    }
}
