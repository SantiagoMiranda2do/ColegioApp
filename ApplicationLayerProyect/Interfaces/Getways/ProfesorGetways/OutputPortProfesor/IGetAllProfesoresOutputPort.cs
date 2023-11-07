using ApplicationLayerProyect.Envoltorios.Profesores;

namespace ApplicationLayerProyect.Interfaces.Getways.ProfesorGetways.OutputPortProfesor
{
    public interface IGetAllProfesoresOutputPort
    {
        ValueTask Handle(EnvoltorioSeleccionarTodosProfesores alumnos);
    }
}
