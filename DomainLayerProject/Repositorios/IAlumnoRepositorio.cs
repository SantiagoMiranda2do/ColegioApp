using DomainLayerProject.Entidades;
using DomainLayerProject.Repositorios.RepositorioComun;

namespace DomainLayerProject.Repositorios
{
    public interface IAlumnoRepositorio : RepositoriosComun
    {

        IEnumerable<Alumnos> GetAll();


    }
}
