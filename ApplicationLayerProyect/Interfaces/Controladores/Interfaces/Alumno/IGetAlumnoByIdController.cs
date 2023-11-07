using ApplicationLayerProyect.Envoltorios.Alumnos;

namespace ApplicationLayerProyect.Interfaces.Controladores.Interfaces.Alumno
{
    public interface IGetAlumnoByIdController
    {

        Task<EnvoltorioSeleccionarAlumno> GetAlumno(int IdAlumno);
    }
}
