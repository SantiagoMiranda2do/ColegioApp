using DomainLayerProject.Entidades;
using DomainLayerProject.Interfaces;

namespace DomainLayerProject.Especificaciones.ProfesorEspecificacion
{
    public class EspecificacionNombreProfesor : NombreEspecificacion<Profesores>, IEspecificacion<Profesores>
    {
        public bool IsSatisfiedBy(Profesores entity)
        {
            throw new NotImplementedException();
        }
    }
}
