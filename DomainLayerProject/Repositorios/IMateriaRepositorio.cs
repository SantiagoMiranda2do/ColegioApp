namespace DomainLayerProject.Repositorios
{
    public interface IMateriaRepositorio
    {
        Task Add(String NombreMateria);
        Task Update(String NombreMateria);
        Task Delete(int id);
        Task GetById(int id);
    }
}
