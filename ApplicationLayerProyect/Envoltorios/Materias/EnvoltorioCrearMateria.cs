using DomainLayerProject.DTOs.DTOValidacion;

namespace ApplicationLayerProyect.Envoltorios.Materias
{
    public class EnvoltorioCrearMateria : EnvoltorioBase
    {


        public int IdMateria { get; set; }
        public List<ValidacionDTO>? ValidacionErrores { get; set; }
    }
}
