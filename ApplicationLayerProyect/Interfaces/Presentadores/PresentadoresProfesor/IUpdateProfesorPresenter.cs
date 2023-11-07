using ApplicationLayerProyect.Envoltorios.Profesores;
using ApplicationLayerProyect.Interfaces.Getways.ProfesorGetways.OutputPortProfesor;

namespace ApplicationLayerProyect.Interfaces.Presentadores.PresentadoresProfesor
{
    public interface IUpdateProfesorPresenter : IUpdateProfesorOutputPort
    {

        EnvoltorioActualizarProfesor Profesor { get; }
    }
}
