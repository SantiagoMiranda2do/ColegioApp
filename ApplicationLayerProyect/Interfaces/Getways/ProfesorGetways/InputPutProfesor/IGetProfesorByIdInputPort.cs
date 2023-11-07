namespace ApplicationLayerProyect.Interfaces.Getways.ProfesorGetways.InputPutProfesor
{
    public interface IGetProfesorByIdInputPort
    {
        Task Handle(int idProfesor);
    }
}
