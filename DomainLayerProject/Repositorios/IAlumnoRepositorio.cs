using DomainLayerProject.Entidades;
using DomainLayerProject.Repositorios.RepositorioComun;

namespace DomainLayerProject.Repositorios
{
    public interface IAlumnoRepositorio : RepositoriosComun<Alumnos>
    {

        IEnumerable<Alumnos> GetAll();


    }
}
