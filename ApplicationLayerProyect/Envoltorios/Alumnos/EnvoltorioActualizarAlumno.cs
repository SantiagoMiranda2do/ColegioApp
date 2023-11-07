using DomainLayerProject.DTOs.DTOValidacion;

namespace ApplicationLayerProyect.Envoltorios.Alumnos
{
    public class EnvoltorioActualizarAlumno : EnvoltorioBase
    {

        public int IdAlumno { get; set; }
        public string NombreAlumno { get; set; }
        public List<ValidacionDTO>? ValidationErrors { get; set; }
    }
}
