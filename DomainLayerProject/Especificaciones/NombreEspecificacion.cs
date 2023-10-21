using DomainLayerProject.DTOs.DTOValidacion;
using DomainLayerProject.Entidades.EntidadComun;
using System.Text.RegularExpressions;

namespace DomainLayerProject.Especificaciones
{
    public class NombreEspecificacion<t>
    {
        public List<string> ErrorMessage => throw new NotImplementedException();



        private bool IsSatisfiedBy(t entity)
        {

            if (string.IsNullOrEmpty(string.Nombre))
            {
                validationErrors.Add(new ValidacionDTO
                {
                    PropertyName = "Nombre",
                    ErrorMessage = "Ingrese su nombre correctamente."
                });
                return false;
            }


            if (string.IsNullOrEmpty(string.Apellido))
            {
                validationErrors.Add(new ValidacionDTO
                {
                    PropertyName = "Nombre",
                    ErrorMessage = "Ingrese su nombre correctamente."
                });
                return false;
            }

            bool noNumero(Persona persona)
            {

                return !Regex.IsMatch(persona.Nombre, @"\d");
                return !Regex.IsMatch(persona.Apellido, @"\d");
            }








            return true;
        }


    }
}
