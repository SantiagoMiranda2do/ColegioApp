using ApplicationLayerProyect.Envoltorios.Profesores;
using ApplicationLayerProyect.Interfaces.Getways.ProfesorGetways.InputPutProfesor;
using ApplicationLayerProyect.Interfaces.Presentadores.PresentadoresProfesor;
using DomainLayerProject.Repositorios;

namespace AplicationLayerUseCase.CasosDeUso.Profesor
{
    public class EliminarProfesorInteractor : IDeleteProfesorInputPort
    {

        private readonly IProfesoresRepositorio _repository;
        private readonly IDeleteProfesorPresenter _presenter;

        public EliminarProfesorInteractor(IProfesoresRepositorio repository, IDeleteProfesorPresenter presenter)
        {
            _repository = repository;
            _presenter = presenter;
        }

        public async Task Handle(int idProfesor)
        {

            EnvoltorioEliminarProfesor profesorResponse = new();
            try
            {
                // Eliminar el profesor
                await _repository.Delete(idProfesor);
                await _repository.SaveChange();
                profesorResponse.IdProfesor = idProfesor;
            }
            catch (DBMySqlException ex)
            {
                // Manejar errores
                profesorResponse.NumeroError = ex.Number;
                profesorResponse.Mensaje = ex.MessageError;
            }
            finally
            {
                // Notificar al presentador que se eliminó el profesor.
                await _presenter.Handle(profesorResponse);
            }
        }
    }
}

