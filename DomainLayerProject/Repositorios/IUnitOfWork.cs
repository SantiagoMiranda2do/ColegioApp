namespace DomainLayerProject.Repositorios
{
    public interface IUnitOfWork
    {
        Task SaveChange();
    }
}
