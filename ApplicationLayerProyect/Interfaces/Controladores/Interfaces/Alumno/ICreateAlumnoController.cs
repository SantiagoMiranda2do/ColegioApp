using ApplicationLayerProyect.Envoltorios.Alumnos;
using DomainLayerProject.DTOs.Request.RequestAlumno;

namespace ApplicationLayerProyect.Interfaces.Controladores.Interfaces.Alumno
{
    public interface ICreateAlumnoController
    {

        Task<EnvoltorioCrearAlumno> CrearAlumno(CrearAlumnoRequest request);
    }
}
