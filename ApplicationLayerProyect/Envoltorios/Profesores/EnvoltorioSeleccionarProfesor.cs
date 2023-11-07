using DomainLayerProject.DTOs.Respuestas;

namespace ApplicationLayerProyect.Envoltorios.Profesores
{
    public class EnvoltorioSeleccionarProfesor : EnvoltorioBase
    {

        public RespuestaProfesor Materia { get; set; }
        public string NombreProfesor { get; set; }
        public int IdProfesor { get; set; }
    }
}
