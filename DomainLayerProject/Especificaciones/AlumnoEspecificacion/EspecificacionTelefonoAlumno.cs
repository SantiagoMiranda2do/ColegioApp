using DomainLayerProject.Entidades;
using DomainLayerProject.Interfaces;

namespace DomainLayerProject.Especificaciones.AlumnoEspecificacion
{
    public class EspecificacionTelefonoAlumno : TelefonoEspecificacion<Alumnos>, IEspecificacion<Alumnos>
    {
        public new List<string> ErrorMessage => throw new NotImplementedException();

        public bool IsSatisfiedBy(Alumnos entity)
        {
            throw new NotImplementedException();
        }
    }
}
