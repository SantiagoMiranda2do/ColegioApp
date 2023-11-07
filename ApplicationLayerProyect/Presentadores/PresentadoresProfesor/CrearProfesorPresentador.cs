using ApplicationLayerProyect.Envoltorios.Profesores;
using ApplicationLayerProyect.Interfaces.Presentadores.PresentadoresProfesor;

namespace ApplicationLayerProyect.Presentadores.PresentadoresProfesor
{
    public class CrearProfesorPresentador : ICreateProfesorPresenter
    {
        public EnvoltorioCrearProfesor Profesor { get; private set; } = new EnvoltorioCrearProfesor();

        public Task Handle(EnvoltorioCrearProfesor profesor)
        {
            Profesor.NumeroError = Profesor.NumeroError;
            Profesor.ValidacionErrores = Profesor.ValidacionErrores;
            Profesor.Mensaje = Profesor.Mensaje;
            Profesor.IdProfesor = Profesor.IdProfesor;
            return Task.CompletedTask;
        }
    }
}
