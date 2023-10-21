using DomainLayerProject.Entidades;
using DomainLayerProject.Interfaces;

namespace DomainLayerProject.Especificaciones.ProfesorEspecificacion
{
    public class EspecificacionDNIProfesor : DNIEspecificacion<Profesores>, IEspecificacion<Profesores>
    {
        public List<string> ErrorMessage => throw new NotImplementedException();

        public bool IsSatisfiedBy(Profesores entity)
        {
            throw new NotImplementedException();
        }
    }
}
