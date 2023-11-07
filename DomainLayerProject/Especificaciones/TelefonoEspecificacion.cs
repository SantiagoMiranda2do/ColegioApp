using DomainLayerProject.DTOs.DTOValidacion;

namespace DomainLayerProject.Especificaciones
{
    public class TelefonoEspecificacion<T>
    {
        public List<string> ErrorMessage => _errors.ConvertAll(e => e.ErrorMessage);
        readonly List<ValidacionDTO> _errors = new List<ValidacionDTO>();

        public bool IsSatisfiedBy(T entity)
        {
            if (!EsTelefonoValido(entity))
            {
                return false;
            }

            return true;
        }

        private bool EsTelefonoValido(T entity)
        {
            int telefono = 0; // Asegúrate de que puedas obtener el valor del teléfono de la entidad.

            if (!EsNumero(telefono.ToString()))
            {
                _errors.Add(new ValidacionDTO
                {
                    PropertyName = "Telefono",
                    ErrorMessage = "Ingrese su número de teléfono correctamente."
                });
                return false;
            }

            return true;
        }

        private bool EsNumero(string texto)
        {
            // Verifica si el texto es un número válido.
            if (int.TryParse(texto, out _))
            {
                return true;
            }
            return false;
        }
    }







}


