using DomainLayerProject.DTOs.Respuestas;

namespace ApplicationLayerProyect.Envoltorios.Alumnos
{
    public class EnvoltorioSeleccionarTodosAlumnos : EnvoltorioBase
    {

        public List<RespuestaAlumno>? Alumnos { get; set; } = new List<RespuestaAlumno>();
    }
}
