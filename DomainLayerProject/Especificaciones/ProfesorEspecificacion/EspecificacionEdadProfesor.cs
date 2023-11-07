using DomainLayerProject.Entidades;
using DomainLayerProject.Interfaces;

namespace DomainLayerProject.Especificaciones.ProfesorEspecificacion
{
    public class EspecificacionEdadProfesor : EdadEspecificacion<Profesores>, IEspecificacion<Profesores>
    {
        public List<string> ErrorMessage => throw new NotImplementedException();

        public bool IsSatisfiedBy(Profesores entity)
        {
            throw new NotImplementedException();
        }
    }
}
