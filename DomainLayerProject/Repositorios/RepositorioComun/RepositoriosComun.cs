namespace DomainLayerProject.Repositorios.RepositorioComun
{
    public interface RepositoriosComun
    {
        Task GetById(int id);
        Task GetByName(string Nombre);
        Task GetByApellido(string Apellido);
        Task GetByEdad(int Edad);
        Task Add(String Nombre);
        Task Update(String Nombre);
        Task Delete(int id);

    }
}
