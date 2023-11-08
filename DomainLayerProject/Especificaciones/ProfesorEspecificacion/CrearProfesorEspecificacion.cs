using DomainLayerProject.DTOs.DTOValidacion;
using DomainLayerProject.DTOs.Request.RequestProfesor;
using DomainLayerProject.Interfaces;

namespace DomainLayerProject.Especificaciones.ProfesorEspecificacion
{
    public class CrearProfesorEspecificacion : IEspecificacion<CrearProfesorRequest>
    {
        readonly CrearProfesorRequest _entity;
        readonly List<ValidacionDTO> _errors => new List<ValidacionDTO>();

        public List<string> ErrorMessage => throw new NotImplementedException();

        public CrearProfesorEspecificacion(CrearProfesorRequest entity)
        {
            this._entity = entity;
        }


        public List<ValidacionDTO> IsValid()
        {
            if (string.IsNullOrEmpty(_entity.NombreProfesor))
            {
                _errors.Add(new ValidacionDTO
                {
                    PropertyName = "Nomre Profesor",
                    ErrorMessage = "El campo no puede ser nulo ni vacío."

                });
            }
            else if (_entity.NombreProfesor.Length > 45)
            {
                _errors.Add(new ValidacionDTO
                {
                    PropertyName = "Nomre Profesor",
                    ErrorMessage = "El campo no puede contener más de 45 caracteres."

                });

            }

            return _errors;
        }

        public bool IsSatisfiedBy(CrearProfesorRequest entity)
        {
            throw new NotImplementedException();
        }
    }
}

