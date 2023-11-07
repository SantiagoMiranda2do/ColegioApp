using ApplicationLayerProyect.Envoltorios.Profesores;

namespace ApplicationLayerProyect.Interfaces.Controladores.Interfaces.Profesor
{
    public interface IGetAllProfesorController
    {
        ValueTask<EnvoltorioSeleccionarTodosProfesores> GetProfesores();
    }
}
