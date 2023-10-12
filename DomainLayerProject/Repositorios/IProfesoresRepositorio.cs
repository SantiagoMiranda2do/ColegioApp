using DomainLayerProject.Repositorios.RepositorioComun;

namespace DomainLayerProject.Repositorios
{
    public interface IProfesoresRepositorio : RepositoriosComun
    {
        Task AsignarProfesor(int IdProfesor, int IdMateria);
    }
}
