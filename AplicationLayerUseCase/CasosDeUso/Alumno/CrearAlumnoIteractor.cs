using ApplicationLayerProyect.Envoltorios.Alumnos;
using ApplicationLayerProyect.Interfaces.Getways.AlumnoGetways.InputPortAlumno;
using ApplicationLayerProyect.Interfaces.Presentadores.PresentadoresAlumno;
using DomainLayerProject.DTOs.DTOValidacion;
using DomainLayerProject.DTOs.Request.RequestAlumno;
using DomainLayerProject.Especificaciones.AlumnoEspecificacion;
using DomainLayerProject.Repositorios;

namespace AplicationLayerUseCase.CasosDeUso.Alumno
{
    public class CrearAlumnoIteractor : ICreateAlumnoInputPort
    {
        readonly IAlumnoRepositorio _repository;
        readonly ICreateAlumnoPresenter _presenter;

        /// <summary>
        /// Constructor de la clase CreateAlumnoIteractor.
        /// </summary>
        /// <param name="repository">El repositorio de alumnos.</param>
        /// <param name="presenter">El presentador para la creación de alumnos.</param>
        public CrearAlumnoIteractor(IAlumnoRepositorio repository, ICreateAlumnoPresenter presenter)
        {
            _repository = repository;
            _presenter = presenter;
        }

        /// <summary>
        /// Maneja la creación de un nuevo alumno.
        /// </summary>
        /// <param name="createAlumnoRequest">Los datos para crear el alumno.</param>
        /// <returns>El ID del nuevo alumno creado o 0 si hubo errores.</returns>
        public async Task Handle(CrearAlumnoRequest createAlumnoRequest)
        {
            List<ValidacionDTO> errors = new List<ValidacionDTO>();
            errors = ValidateAlumno(createAlumnoRequest);
            EnvoltorioCrearAlumno alumnoResponse = new();

            if (errors.Any())
            {
                alumnoResponse.ValidacionErrores = errors;
                await _presenter.Handle(alumnoResponse);
                return;
            }

            Alumno newAlumno = new()
            {
                NombreAlumno = createAlumnoRequest.NombreAlumno
            };

            try
            {
                await _repository.Create(newAlumno);
                await _repository.SaveChange();
                alumnoResponse.IdAlumno = newAlumno.Id;
            }
            catch (DBMySqlException ex)
            {
                alumnoResponse.NumeroError = ex.Number;
                alumnoResponse.Mensaje = ex.MessageError;
            }
            finally
            {
                await _presenter.Handle(alumnoResponse);
            }
        }

        private List<ValidacionDTO> ValidateAlumno(CrearAlumnoRequest createAlumnoRequest)
        {
            var specification = new CrearAlumnoEspecificacion(createAlumnoRequest);
            return specification.IsValid();
        }
    }
}
