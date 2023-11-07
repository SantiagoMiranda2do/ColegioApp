using DomainLayerProject.DTOs.DTOValidacion;

namespace ApplicationLayerProyect.Envoltorios.Materias
{
    public class EnvoltorioActualizarMateria : EnvoltorioBase
    {

        public int IdMateria { get; set; }
        public string NombreMateria { get; set; }
        public List<ValidacionDTO>? ValidationErrors { get; set; }
    }
}
