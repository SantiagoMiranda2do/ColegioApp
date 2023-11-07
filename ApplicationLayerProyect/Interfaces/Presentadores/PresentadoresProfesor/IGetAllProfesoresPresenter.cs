using ApplicationLayerProyect.Envoltorios.Profesores;
using ApplicationLayerProyect.Interfaces.Getways.ProfesorGetways.OutputPortProfesor;

namespace ApplicationLayerProyect.Interfaces.Presentadores.PresentadoresProfesor
{
    public interface IGetAllProfesoresPresenter : IGetAllProfesoresOutputPort
    {

        EnvoltorioSeleccionarTodosProfesores Profesor { get; }
    }
}
