using DomainLayerProject.Entidades.EntidadComun;
using DomainLayerProject.Interfaces;
using System.Text.RegularExpressions;

namespace DomainLayerProject.Especificaciones
{
    public class NombreEspecificacion : IEspecificacion<Persona>
    {
        public List<string> ErrorMessage => throw new NotImplementedException();



        private bool IsSatisfiedBy(Persona persona)
        {

            if (string.IsNullOrEmpty(persona.Nombre))
            {
                return false;
            }


            if (string.IsNullOrEmpty(persona.Apellido))
            {
                return false;
            }

            public bool noNumero(Persona persona)
            {

                return !Regex.IsMatch(persona.Nombre, @"\d");
                return !Regex.IsMatch(persona.Apellido, @"\d");
            }








            return true;
        }

        bool IEspecificacion<Persona>.IsSatisfiedBy(Persona entity)
        {
            throw new NotImplementedException();
        }
    }
}
