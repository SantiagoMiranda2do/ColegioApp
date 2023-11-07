using DomainLayerProject.DTOs.DTOValidacion;

namespace ApplicationLayerProyect.Envoltorios.Profesores
{
    public class EnvoltorioActualizarProfesor : EnvoltorioBase
    {


        public int IdProfesor { get; set; }
        public string NombreProfesor { get; set; }
        public List<ValidacionDTO>? ValidationErrors { get; set; }
    }
}

