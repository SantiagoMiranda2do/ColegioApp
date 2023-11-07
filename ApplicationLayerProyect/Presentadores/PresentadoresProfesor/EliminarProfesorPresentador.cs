using ApplicationLayerProyect.Envoltorios.Profesores;
using ApplicationLayerProyect.Interfaces.Presentadores.PresentadoresProfesor;

namespace ApplicationLayerProyect.Presentadores.PresentadoresProfesor
{
    public class EliminarProfesorPresentador : IDeleteProfesorPresenter
    {
        public EnvoltorioEliminarProfesor Profesor { get; private set; } = new EnvoltorioEliminarProfesor();

        public Task Handle(EnvoltorioEliminarProfesor profesor)
        {
            Profesor.NumeroError = Profesor.NumeroError;
            Profesor.Mensaje = Profesor.Mensaje;
            Profesor.IdProfesor = Profesor.IdProfesor;
            return Task.CompletedTask;
        }
    }
}
