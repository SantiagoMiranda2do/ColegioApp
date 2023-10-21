using DomainLayerProject.Entidades;
using DomainLayerProject.Repositorios.RepositorioComun;

namespace DomainLayerProject.Repositorios
{
    public interface IProfesoresRepositorio : RepositoriosComun<Profesores>
    {
        Task AsignarProfesor(int IdProfesor, int IdMateria);
    }
}
