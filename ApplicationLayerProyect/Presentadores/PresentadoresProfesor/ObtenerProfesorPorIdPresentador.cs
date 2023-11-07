using ApplicationLayerProyect.Envoltorios.Profesores;
using ApplicationLayerProyect.Interfaces.Presentadores.PresentadoresProfesor;

namespace ApplicationLayerProyect.Presentadores.PresentadoresProfesor
{
    public class ObtenerProfesorPorIdPresentador : IGetProfesorByIdPresenter
    {
        public EnvoltorioSeleccionarProfesor Profesor { get; private set; }

        public Task handle(EnvoltorioSeleccionarProfesor profesor)
        {
            Profesor = new EnvoltorioSeleccionarProfesor
            {
                NombreProfesor = Profesor.NombreProfesor,
                NumeroError = Profesor.NumeroError,
                Mensaje = Profesor.Mensaje,
                IdProfesor = Profesor.IdProfesor
            };
            return Task.CompletedTask;
        }
    }
}
