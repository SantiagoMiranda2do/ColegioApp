using ApplicationLayerProyect.Envoltorios.Profesores;

namespace ApplicationLayerProyect.Interfaces.Controladores.Interfaces.Profesor
{
    public interface IGetProfesorByIdController
    {
        Task<EnvoltorioSeleccionarProfesor> GetProfesor(int IdProfesor);
    }
}
