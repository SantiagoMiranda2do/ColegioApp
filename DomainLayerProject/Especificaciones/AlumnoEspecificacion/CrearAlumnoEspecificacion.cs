using DomainLayerProject.DTOs.DTOValidacion;
using DomainLayerProject.DTOs.Request.RequestAlumno;
using DomainLayerProject.Interfaces;

namespace DomainLayerProject.Especificaciones.AlumnoEspecificacion
{
    public class CrearAlumnoEspecificacion : IEspecificacion<CrearAlumnoRequest>
    {
        readonly CrearAlumnoRequest _entity;
        readonly List<ValidacionDTO> _errors => new List<ValidacionDTO>();

        public List<string> ErrorMessage => throw new NotImplementedException();

        public CrearAlumnoEspecificacion(CrearAlumnoRequest entity)
        {
            this._entity = entity;
        }


        public List<ValidacionDTO> IsValid()
        {
            if (string.IsNullOrEmpty(_entity.NombreAlumno))
            {
                _errors.Add(new ValidacionDTO
                {
                    PropertyName = "Nomre Alumno",
                    ErrorMessage = "El campo no puede ser nulo ni vacío."

                });
            }
            else if (_entity.NombreAlumno.Length > 45)
            {
                _errors.Add(new ValidacionDTO
                {
                    PropertyName = "Nomre Alumno",
                    ErrorMessage = "El campo no puede contener más de 45 caracteres."

                });

            }

            return _errors;



        }

        public bool IsSatisfiedBy(CrearAlumnoRequest entity)
        {
            throw new NotImplementedException();
        }
    }
}
