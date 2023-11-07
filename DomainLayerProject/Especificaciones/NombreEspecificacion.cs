using DomainLayerProject.DTOs.DTOValidacion;
using System.Text.RegularExpressions;

namespace DomainLayerProject.Especificaciones
{
    public class NombreEspecificacion<T>
    {
        public List<string> ErrorMessage => _errors.ConvertAll(e => e.ErrorMessage);
        readonly List<ValidacionDTO> _errors = new List<ValidacionDTO>();

        public bool IsSatisfiedBy(T entity)
        {
            if (!EsNombreValido(entity))
            {
                return false;
            }

            if (!EsApellidoValido(entity))
            {
                return false;
            }

            return true;
        }

        private bool EsNombreValido(T entity)
        {
            string nombre = entity.GetType().GetProperty("Nombre")?.GetValue(entity) as string;

            if (string.IsNullOrEmpty(nombre))
            {
                _errors.Add(new ValidacionDTO
                {
                    PropertyName = "Nombre",
                    ErrorMessage = "Ingrese su nombre correctamente."
                });
                return false;
            }

            if (ContieneNumeros(nombre))
            {
                _errors.Add(new ValidacionDTO
                {
                    PropertyName = "Nombre",
                    ErrorMessage = "El nombre no debe contener números."
                });
                return false;
            }

            return true;
        }

        private bool EsApellidoValido(T entity)
        {
            string apellido = entity.GetType().GetProperty("Apellido")?.GetValue(entity) as string;

            if (string.IsNullOrEmpty(apellido))
            {
                _errors.Add(new ValidacionDTO
                {
                    PropertyName = "Apellido",
                    ErrorMessage = "Ingrese su apellido correctamente."
                });
                return false;
            }

            if (ContieneNumeros(apellido))
            {
                _errors.Add(new ValidacionDTO
                {
                    PropertyName = "Apellido",
                    ErrorMessage = "El apellido no debe contener números."
                });
                return false;
            }

            return true;
        }

        private bool ContieneNumeros(string texto)
        {
            return Regex.IsMatch(texto, @"\d");
        }
    }
}
