using ApplicationLayerProyect.Envoltorios.Alumnos;
using ApplicationLayerProyect.Interfaces.Getways.AlumnoGetways.InputPortAlumno;
using ApplicationLayerProyect.Interfaces.Presentadores.PresentadoresAlumno;
using DomainLayerProject.Repositorios;

namespace AplicationLayerUseCase.CasosDeUso.Alumno
{
    public class EliminarAlumnoInteractor : IDeleteAlumnoInputPort
    {
        private readonly IAlumnoRepositorio _repository;
        private readonly IDeleteAlumnoPresenter _presenter;

        public EliminarAlumnoInteractor(IAlumnoRepositorio repository, IDeleteAlumnoPresenter presenter)
        {
            _repository = repository;
            _presenter = presenter;
        }

        public async Task Handle(int idAlumno)
        {

            EnvoltorioEliminarAlumno alumnoResponse = new();
            try
            {
                // Eliminar el alumno
                await _repository.Delete(idAlumno);
                await _repository.SaveChange();
                alumnoResponse.IdAlumno = idAlumno;
            }
            catch (DBMySqlException ex)
            {
                // Manejar errores
                alumnoResponse.NumeroError = ex.Number;
                alumnoResponse.Mensaje = ex.MessageError;
            }
            finally
            {
                // Notificar al presentador que se eliminó el alumno.
                await _presenter.handle(alumnoResponse);
            }
        }
    }
}
