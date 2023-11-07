using ApplicationLayerProyect.Envoltorios.Profesores;
using DomainLayerProject.DTOs.Request.RequestProfesor;

namespace ApplicationLayerProyect.Interfaces.Controladores.Interfaces.Profesor
{
    public interface ICreateProfesorController
    {

        Task<EnvoltorioCrearProfesor> CrearProfesor(CrearProfesorRequest request);
    }
}
