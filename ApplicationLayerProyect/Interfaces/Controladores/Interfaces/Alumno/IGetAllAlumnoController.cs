using ApplicationLayerProyect.Envoltorios.Alumnos;

namespace ApplicationLayerProyect.Interfaces.Controladores.Interfaces.Alumno
{
    public interface IGetAllAlumnoController
    {

        ValueTask<EnvoltorioSeleccionarTodosAlumnos> GetAlumnos();
    }
}
