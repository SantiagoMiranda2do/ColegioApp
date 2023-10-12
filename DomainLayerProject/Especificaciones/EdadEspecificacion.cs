using DomainLayerProject.Entidades.EntidadComun;
using DomainLayerProject.Interfaces;

namespace DomainLayerProject.Especificaciones
{
    public class EdadEspecificacion : IEspecificacion<Persona>
    {
        public List<string> ErrorMessage => throw new NotImplementedException();

        public bool IsSatisfiedBy(Persona entity)
        {
            throw new NotImplementedException();
        }


        private bool EsEnteroValido(string valor)
        {
            int edad;
            return int.TryParse(valor, out edad);
        }







    }
}
