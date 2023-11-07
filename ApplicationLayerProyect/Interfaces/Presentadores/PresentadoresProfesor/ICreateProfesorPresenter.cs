using ApplicationLayerProyect.Envoltorios.Profesores;
using ApplicationLayerProyect.Interfaces.Getways.ProfesorGetways.OutputPortProfesor;

namespace ApplicationLayerProyect.Interfaces.Presentadores.PresentadoresProfesor
{
    public interface ICreateProfesorPresenter : ICreateProfesorOutputPort
    {

        EnvoltorioCrearProfesor Profesor { get; }
    }
}
