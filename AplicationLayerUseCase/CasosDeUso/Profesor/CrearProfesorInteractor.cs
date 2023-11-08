using ApplicationLayerProyect.Envoltorios.Profesores;
using ApplicationLayerProyect.Interfaces.Getways.ProfesorGetways.InputPutProfesor;
using ApplicationLayerProyect.Interfaces.Presentadores.PresentadoresProfesor;
using DomainLayerProject.DTOs.DTOValidacion;
using DomainLayerProject.DTOs.Request.RequestProfesor;
using DomainLayerProject.Especificaciones.ProfesorEspecificacion;
using DomainLayerProject.Repositorios;

namespace AplicationLayerUseCase.CasosDeUso.Profesor
{
    public class CrearProfesorInteractor : ICreateProfesorInputPort
    {

        readonly IProfesoresRepositorio _repository;
        readonly ICreateProfesorPresenter _presenter;

        /// <summary>
        /// Constructor de la clase CreateAlumnoIteractor.
        /// </summary>
        /// <param name="repository">El repositorio de profesores.</param>
        /// <param name="presenter">El presentador para la creación de profesores.</param>
        public CrearProfesorInteractor(IProfesoresRepositorio repository, ICreateProfesorPresenter presenter)
        {
            _repository = repository;
            _presenter = presenter;
        }

        /// <summary>
        /// Maneja la creación de un nuevo profesor.
        /// </summary>
        /// <param name="createProfesorRequest">Los datos para crear el profesor.</param>
        /// <returns>El ID del nuevo profesor creado o 0 si hubo errores.</returns>
        public async Task Handle(CrearProfesorRequest createProfesorRequest)
        {
            List<ValidacionDTO> errors = new List<ValidacionDTO>();
            errors = ValidateProfesor(createProfesorRequest);
            EnvoltorioCrearProfesor profesorResponse = new();

            if (errors.Any())
            {
                profesorResponse.ValidacionErrores = errors;
                await _presenter.Handle(profesorResponse);
                return;
            }

            Profesor newProfesor = new()
            {
                NombreProfesor = createProfesorRequest.NombreProfesor
            };

            try
            {
                await _repository.Create(newProfesor);
                await _repository.SaveChange();
                profesorResponse.IdProfesor = newProfesor.Id;
            }
            catch (DBMySqlException ex)
            {
                profesorResponse.NumeroError = ex.Number;
                profesorResponse.Mensaje = ex.MessageError;
            }
            finally
            {
                await _presenter.Handle(profesorResponse);
            }
        }

        private List<ValidacionDTO> ValidateProfesor(CrearProfesorRequest createProfesorRequest)
        {
            var specification = new CrearProfesorEspecificacion(createProfesorRequest);
            return specification.IsValid();
        }
    }
}

