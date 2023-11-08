using ApplicationLayerProyect.Envoltorios.Profesores;
using ApplicationLayerProyect.Interfaces.Presentadores.PresentadoresProfesor;
using DomainLayerProject.DTOs.DTOValidacion;
using DomainLayerProject.DTOs.Request.RequestProfesor;
using DomainLayerProject.Especificaciones.ProfesorEspecificacion;
using DomainLayerProject.Repositorios;

namespace AplicationLayerUseCase.CasosDeUso.Profesor
{
    public class ActualizarProfesorInteractor
    {

        private readonly IProfesoresRepositorio _repository;
        private readonly IUpdateProfesorPresenter _presenter;

        public ActualizarProfesorInteractor(IProfesoresRepositorio repository, IUpdateProfesorPresenter presenter)
        {
            _repository = repository;
            _presenter = presenter;
        }

        public async Task Handle(ActualizarProfesorRequest updateProfesorRequest)
        {
            List<ValidacionDTO> errors = new List<ValidacionDTO>();
            EnvoltorioActualizarProfesor profesorResponse = new();

            try
            {
                //Valida los datos del profesor a actualizar.
                errors = ValidateProfesor(ActualizarProfesorRequest);

                if (errors.Any())
                {
                    // Manejar el caso en el que el profesor no cumpla con las validaciones.
                    // Devuelve un mensaje indicando que los datos del profesor no son validos.
                    profesorResponse.ValidationErrors = errors;
                    await _presenter.handle(profesorResponse);
                    return;
                }

                // Obtener el profesor existente por su ID
                Profesor existingProfesor = await _repository.GetById(updateProfesorRequest.IdProfesor);
                if (existingProfesor == null)
                {
                    // Manejar el caso en el que el profesor no existe
                    // Devuelve un mensaje indicando que el profesor no se encontró.
                    profesorResponse.NumeroError = 404;
                    profesorResponse.Mensaje = $"El profesor con {updateProfesorRequest.IdProfesor} no existe";
                    await _presenter.handle(profesorResponse);
                    return;
                }

                // Actualizar la información del profesor con los datos proporcionados
                existingProfesor.NombreProfesor = updateProfesorRequest.NombreProfesor;

                // Realizar la actualización en el repositorio
                await _repository.Update(existingProfesor);
                await _repository.SaveChange();

                // Crear un objeto de respuesta exitosa
                profesorResponse.IdProfesor = existingProfesor.Id;
                profesorResponse.NombreProfesor = existingProfesor.NombreProfesor;

                // Enviar la respuesta al presentador
                await _presenter.handle(profesorResponse);
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que pueda ocurrir durante la actualización
                profesorResponse.Mensaje = ex.Message;
            }
            finally
            {
                await _presenter.handle(profesorResponse);
            }
        }

        private List<ValidacionDTO> ValidateProfesor(ActualizarProfesorRequest updateProfesorRequest)
        {
            var specification = new ActualizarProfesorEspecificacion(updateProfesorRequest);
            return specification.IsValid();
        }
    }

}

