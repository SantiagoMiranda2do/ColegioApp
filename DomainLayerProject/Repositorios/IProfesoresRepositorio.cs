using DomainLayerProject.Entidades;
using DomainLayerProject.Repositorios.RepositorioComun;

namespace DomainLayerProject.Repositorios
{
    public interface IProfesoresRepositorio : RepositoriosComun<Profesores>, IUnitOfWork
    {
        Task AsignarProfesor(int IdProfesor, int IdMateria);
        Task<IEnumerable<object>> GetAllProfesores();
    }
}
