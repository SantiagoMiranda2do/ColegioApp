using DomainLayerProject.Entidades.EntidadComun;
using DomainLayerProject.Interfaces;

namespace DomainLayerProject.Especificaciones
{
    public class DNIEspecificacion : IEspecificacion<Persona>
    {
        public List<string> ErrorMessage => throw new NotImplementedException();

        public bool IsSatisfiedBy(Persona entity)
        {
            throw new NotImplementedException();
        }

        private bool EsDniValido(Persona DNI)
        {

            if (ContieneLetras(DNI))
            {
                return false;
            }


            if (ContienePuntos(DNI))
            {
                return false;
            }



            return true;
        }

        private bool ContieneLetras(Persona DNI)
        {
            foreach (char c in DNI)
            {
                if (char.IsLetter(c))
                {
                    return true; // La cadena contiene al menos una letra.
                }
            }
            return false;
        }

        private bool ContienePuntos(string dni)
        {
            return dni.Contains(".");
        }





    }
}
