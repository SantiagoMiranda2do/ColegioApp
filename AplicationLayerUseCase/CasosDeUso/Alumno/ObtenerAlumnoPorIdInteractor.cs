using ApplicationLayerProyect.Envoltorios.Alumnos;
using ApplicationLayerProyect.Interfaces.Getways.AlumnoGetways.InputPortAlumno;
using ApplicationLayerProyect.Interfaces.Presentadores.PresentadoresAlumno;
using DomainLayerProject.Repositorios;

namespace AplicationLayerUseCase.CasosDeUso.Alumno
{
    public class ObtenerAlumnoPorIdInteractor : IGetAlumnoByIdInputPort
    {
        private readonly IAlumnoRepositorio _repository;
        private readonly IGetAlumnoByIdPresenter _presenter;

        public ObtenerAlumnoPorIdInteractor(IAlumnoRepositorio repository, IGetAlumnoByIdPresenter presenter)
        {
            _repository = repository;
            _presenter = presenter;
        }

        public async Task Handle(int idAlumno)
        {
            EnvoltorioSeleccionarAlumno alumnoResponse = new();

            try
            {
                var existingAlumno = await _repository.GetById(idAlumno);
                if (existingAlumno != null)
                {
                    alumnoResponse.IdAlumno = existingAlumno.Id;
                    alumnoResponse.NombreAlumno = existingAlumno.NombreAlumno;
                }
                else
                {
                    alumnoResponse.NumeroError = 404;
                    alumnoResponse.Mensaje = "El Id proporcionado es inválido o no existe.";

                }

            }
            catch (Exception ex)
            {

                alumnoResponse.Mensaje = ex.Message;

            }
            finally
            {
                await _presenter.handle(alumnoResponse);
            }
        }
    }
}

