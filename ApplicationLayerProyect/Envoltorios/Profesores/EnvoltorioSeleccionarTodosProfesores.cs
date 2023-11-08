using DomainLayerProject.DTOs.Respuestas;

namespace ApplicationLayerProyect.Envoltorios.Profesores
{
    public class EnvoltorioSeleccionarTodosProfesores
    {
        public List<RespuestaProfesor>? Profesores { get; set; } = new List<RespuestaProfesor>();
        public object NumeroError { get; set; }
        public object Mensaje { get; set; }
    }
}
