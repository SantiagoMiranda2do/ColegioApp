using ApplicationLayerProyect.Envoltorios.Profesores;
using ApplicationLayerProyect.Interfaces.Getways.ProfesorGetways.InputPutProfesor;
using ApplicationLayerProyect.Interfaces.Presentadores.PresentadoresProfesor;
using DomainLayerProject.DTOs.Respuestas;
using DomainLayerProject.Repositorios;

namespace AplicationLayerUseCase.CasosDeUso.Profesor
{
    public class ObtenerTodosProfesoresIterator : IGetAllProfesoresInputPort
    {
        private readonly IProfesoresRepositorio _repository;
        private readonly IGetAllProfesoresPresenter _presenter;

        public ObtenerTodosProfesoresIterator(IProfesoresRepositorio repository, IGetAllProfesoresPresenter presenter)
        {
            _repository = repository;
            _presenter = presenter;
        }

        public async ValueTask Handle()
        {
            EnvoltorioSeleccionarTodosProfesores profesoresResponse = new();
            try
            {
                var existingProfesores = await _repository.GetAllProfesores();

                if (existingProfesores != null && existingProfesores.Count > 0)
                {
                    foreach (var profesor in existingProfesores)
                    {
                        profesoresResponse.Profesores.Add(new RespuestaProfesor
                        {
                            IdProfesor = profesor.Id,
                            NombreProfesor = profesor.NombreProfesor
                        });
                    }
                }
                else
                {
                    profesoresResponse.NumeroError = 404;
                    profesoresResponse.Mensaje = "No existen registros en la tabla Profesores.";
                }

            }
            catch (DBMySqlException ex)
            {
                profesoresResponse.NumeroError = ex.Numero;
                profesoresResponse.Mensaje = ex.ErrorMensaje;

            }
            finally
            {
                await _presenter.Handle(profesoresResponse);
            }
        }

        Task IGetAllProfesoresInputPort.Handle()
        {
            throw new NotImplementedException();
        }
    }
}
