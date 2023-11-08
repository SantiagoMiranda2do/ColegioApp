using ApplicationLayerProyect.Envoltorios.Alumnos;
using ApplicationLayerProyect.Interfaces.Getways.AlumnoGetways.InputPortAlumno;
using ApplicationLayerProyect.Interfaces.Presentadores.PresentadoresAlumno;
using DomainLayerProject.DTOs.Respuestas;
using DomainLayerProject.Repositorios;

namespace AplicationLayerUseCase.CasosDeUso.Alumno
{
    public class ObtenerTodosAlumnosIterator : IGetAllAlumnosInputPort
    {
        private readonly IAlumnoRepositorio _repository;
        private readonly IGetAllAlumnosPresenter _presenter;

        public ObtenerTodosAlumnosIterator(IAlumnoRepositorio repository, IGetAllAlumnosPresenter presenter)
        {
            _repository = repository;
            _presenter = presenter;
        }

        public async ValueTask Handle()
        {
            EnvoltorioSeleccionarTodosAlumnos alumnosResponse = new();
            try
            {
                var existingAlumnos = await _repository.GetAllAlumnos();

                if (existingAlumnos != null && existingAlumnos.Count > 0)
                {
                    foreach (var alumno in existingAlumnos)
                    {
                        alumnosResponse.Alumnos.Add(new RespuestaAlumno
                        {
                            IdAlumno = alumno.Id,
                            NombreAlumno = alumno.NombreAlumno
                        });
                    }
                }
                else
                {
                    alumnosResponse.NumeroError = 404;
                    alumnosResponse.Mensaje = "No existen registros en la tabla Alumnos.";
                }

            }
            catch (DBMySqlException ex)
            {
                alumnosResponse.NumeroError = ex.Numero;
                alumnosResponse.Mensaje = ex.ErrorMensaje;

            }
            finally
            {
                await _presenter.Handle(alumnosResponse);
            }
        }
    }
}