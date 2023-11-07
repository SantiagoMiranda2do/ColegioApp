namespace ApplicationLayerProyect.Interfaces.Getways.AlumnoGetways.InputPortAlumno
{
    public interface IGetAlumnoByIdInputPort
    {
        Task Handle(int idAlumno);
    }
}
