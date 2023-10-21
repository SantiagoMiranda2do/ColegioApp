using DomainLayerProject.Entidades;
using DomainLayerProject.Interfaces;

namespace DomainLayerProject.Especificaciones.AlumnoEspecificacion
{
    public class EspecificacionEdadAlumno : EdadEspecificacion<Alumnos>, IEspecificacion<Alumnos>
    {
        public List<string> ErrorMessage => throw new NotImplementedException();

        public bool IsSatisfiedBy(Alumnos entity)
        {
            throw new NotImplementedException();
        }
    }
}
