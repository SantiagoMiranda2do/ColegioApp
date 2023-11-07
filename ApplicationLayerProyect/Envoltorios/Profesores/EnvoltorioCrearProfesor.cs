using DomainLayerProject.DTOs.DTOValidacion;

namespace ApplicationLayerProyect.Envoltorios.Profesores
{
    public class EnvoltorioCrearProfesor : EnvoltorioBase
    {

        public int IdProfesor { get; set; }
        public List<ValidacionDTO>? ValidacionErrores { get; set; }
    }
}
