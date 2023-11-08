using ApplicationLayerProyect.Envoltorios.Alumnos;
using ApplicationLayerProyect.Interfaces.Getways.AlumnoGetways.InputPortAlumno;
using ApplicationLayerProyect.Interfaces.Presentadores.PresentadoresAlumno;
using DomainLayerProject.DTOs.DTOValidacion;
using DomainLayerProject.DTOs.Request.RequestAlumno;
using DomainLayerProject.Especificaciones.AlumnoEspecificacion;
using DomainLayerProject.Repositorios;

namespace AplicationLayerUseCase.CasosDeUso.Alumno
{
    public class ActualizarAlumnoInteractor : IUpdateAlumnoInputPort
    {
        private readonly IAlumnoRepositorio _repository;
        private readonly IUpdateAlumnoPresenter _presenter;

        public ActualizarAlumnoInteractor(IAlumnoRepositorio repository, IUpdateAlumnoPresenter presenter)
        {
            _repository = repository;
            _presenter = presenter;
        }

        public async Task Handle(ActualizarAlumnoRequest updateAlumnoRequest)
        {
            List<ValidacionDTO> errors = new List<ValidacionDTO>();
            EnvoltorioActualizarAlumno alumnoResponse = new();

            try
            {
                //Valida los datos del alumno a actualizar.
                errors = ValidateAlumno(ActualizarAlumnoRequest);

                if (errors.Any())
                {
                    // Manejar el caso en el que el alumno no cumpla con las validaciones.
                    // Devuelve un mensaje indicando que los datos del alumno no son validos.
                    alumnoResponse.ValidationErrors = errors;
                    await _presenter.handle(alumnoResponse);
                    return;
                }

                // Obtener el alumno existente por su ID
                Alumno existingAlumno = await _repository.GetById(updateAlumnoRequest.IdAlumno);
                if (existingAlumno == null)
                {
                    // Manejar el caso en el que el alumno no existe
                    // Devuelve un mensaje indicando que el alumno no se encontró.
                    alumnoResponse.NumeroError = 404;
                    alumnoResponse.Mensaje = $"El alumno con {updateAlumnoRequest.IdAlumno} no existe";
                    await _presenter.handle(alumnoResponse);
                    return;
                }

                // Actualizar la información del alumno con los datos proporcionados
                existingAlumno.NombreAlumno = updateAlumnoRequest.NombreAlumno;

                // Realizar la actualización en el repositorio
                await _repository.Update(existingAlumno);
                await _repository.SaveChange();

                // Crear un objeto de respuesta exitosa
                alumnoResponse.IdAlumno = existingAlumno.Id;
                alumnoResponse.NombreAlumno = existingAlumno.NombreAlumno;

                // Enviar la respuesta al presentador
                await _presenter.handle(alumnoResponse);
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que pueda ocurrir durante la actualización
                alumnoResponse.Mensaje = ex.Message;
            }
            finally
            {
                await _presenter.handle(alumnoResponse);
            }
        }

        private List<ValidacionDTO> ValidateAlumno(ActualizarAlumnoRequest updateAlumnoRequest)
        {
            var specification = new ActualizarAlumnoEspecificacion(updateAlumnoRequest);
            return specification.IsValid();
        }
    }
}
