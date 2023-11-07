using ApplicationLayerProyect.Envoltorios.Alumnos;

namespace ApplicationLayerProyect.Interfaces.Getways.AlumnoGetways.OutputPortAlumno
{
    public interface IGetAllAlumnosOutputPort
    {

        ValueTask Handle(EnvoltorioSeleccionarTodosAlumnos alumnos);
    }
}
