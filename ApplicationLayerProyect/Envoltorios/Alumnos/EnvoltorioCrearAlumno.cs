using DomainLayerProject.DTOs.DTOValidacion;

namespace ApplicationLayerProyect.Envoltorios.Alumnos
{
    public class EnvoltorioCrearAlumno : EnvoltorioBase
    {


        public int IdAlumno { get; set; }
        public List<ValidacionDTO>? ValidacionErrores { get; set; }
    }
}
