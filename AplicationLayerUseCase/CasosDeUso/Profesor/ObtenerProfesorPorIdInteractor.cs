using ApplicationLayerProyect.Envoltorios.Profesores;
using ApplicationLayerProyect.Interfaces.Getways.ProfesorGetways.InputPutProfesor;
using ApplicationLayerProyect.Interfaces.Presentadores.PresentadoresProfesor;
using DomainLayerProject.Repositorios;

namespace AplicationLayerUseCase.CasosDeUso.Profesor
{
    public class ObtenerProfesorPorIdInteractor : IGetProfesorByIdInputPort
    {


        private readonly IProfesoresRepositorio _repository;
        private readonly IGetProfesorByIdPresenter _presenter;

        public ObtenerProfesorPorIdInteractor(IProfesoresRepositorio repository, IGetProfesorByIdPresenter presenter)
        {
            _repository = repository;
            _presenter = presenter;
        }

        public async Task Handle(int idProfesor)
        {
            EnvoltorioSeleccionarProfesor profesorResponse = new();

            try
            {
                var existingProfesor = await _repository.GetById(idProfesor);
                if (existingProfesor != null)
                {
                    profesorResponse.IdProfesor = existingProfesor.Id;
                    profesorResponse.NombreProfesor = existingProfesor.NombreProfesor;
                }
                else
                {
                    profesorResponse.NumeroError = 404;
                    profesorResponse.Mensaje = "El Id proporcionado es inválido o no existe.";

                }

            }
            catch (Exception ex)
            {

                profesorResponse.Mensaje = ex.Message;

            }
            finally
            {
                await _presenter.handle(profesorResponse);
            }
        }
    }
}

