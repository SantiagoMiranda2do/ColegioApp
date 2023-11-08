using DomainLayerProject.Entidades;
using DomainLayerProject.Repositorios.RepositorioComun;

namespace DomainLayerProject.Repositorios
{
    public interface IAlumnoRepositorio : RepositoriosComun<Alumnos>, IUnitOfWork
    {

        IEnumerable<Alumnos> GetAll();
        Task<IEnumerable<object>> GetAllAlumnos();
    }
}
