using DomainLayerProject.DTOs.DTOValidacion;
using DomainLayerProject.DTOs.Request.RequestProfesor;
using DomainLayerProject.Interfaces;

namespace DomainLayerProject.Especificaciones.ProfesorEspecificacion
{
    public class ActualizarProfesorEspecificacion : IEspecificacion<ActualizarProfesorRequest>
    {


        readonly ActualizarProfesorRequest _entity;
        readonly List<ValidacionDTO> _errors = new List<ValidacionDTO>();

        public ActualizarProfesorEspecificacion(ActualizarProfesorRequest entity)
        {
            _entity = entity;
        }

        public List<string> ErrorMessage => throw new NotImplementedException();

        public bool IsSatisfiedBy(ActualizarProfesorRequest entity)
        {
            throw new NotImplementedException();
        }

        public List<ValidacionDTO> IsValid()
        {
            if (_entity.IdProfesor == 0)
            {
                _errors.Add(new ValidacionDTO()
                {
                    PropertyName = "Id",
                    ErrorMessage = "Debe especificar el Id que desea actualizar"
                });
            }

            if (string.IsNullOrEmpty(_entity.NombreProfesor))
            {
                _errors.Add(new ValidacionDTO
                {
                    PropertyName = "Nombre Profesor",
                    ErrorMessage = "El campo no puede ser nulo ni vacío."

                });
            }
            if (!string.IsNullOrEmpty(_entity.NombreProfesor) && _entity.NombreProfesor.Length > 45)
            {
                _errors.Add(new ValidacionDTO
                {
                    PropertyName = "Nombre Profesor",
                    ErrorMessage = "El campo no puede contener más de 45 caracteres."

                });

            }

            return _errors;
        }
    }
}

