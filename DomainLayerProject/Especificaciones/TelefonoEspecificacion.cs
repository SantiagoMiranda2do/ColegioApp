using DomainLayerProject.Entidades.EntidadComun;
using DomainLayerProject.Interfaces;

namespace DomainLayerProject.Especificaciones
{
    public class TelefonoEspecificacion : IEspecificacion<Persona>
    {
        public List<string> ErrorMessage => throw new NotImplementedException();

        public bool IsSatisfiedBy(Persona entity)
        {
            throw new NotImplementedException();
        }

        private bool EsTelefonoValido(Persona Telefono)
        {
            foreach (char c in Telefono)
            {
                if (char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;







        }
    }
}
