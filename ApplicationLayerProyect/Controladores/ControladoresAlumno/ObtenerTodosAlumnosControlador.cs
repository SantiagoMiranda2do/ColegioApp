using ApplicationLayerProyect.Envoltorios.Alumnos;
using ApplicationLayerProyect.Interfaces.Controladores.Interfaces.Alumno;
using ApplicationLayerProyect.Interfaces.Getways.AlumnoGetways.InputPortAlumno;
using ApplicationLayerProyect.Interfaces.Presentadores.PresentadoresAlumno;

namespace ApplicationLayerProyect.Controladores.ControladoresAlumno
{
    public class ObtenerTodosAlumnosControlador : IGetAllAlumnoController
    {
        readonly IGetAllAlumnosInputPort _inputPort;
        readonly IGetAllAlumnosPresenter _presenter;


        public ObtenerTodosAlumnosControlador(IGetAllAlumnosInputPort inputPort, IGetAllAlumnosPresenter presenter)
        {

            _inputPort = inputPort;
            _presenter = presenter;


        }


        public async ValueTask<EnvoltorioSeleccionarTodosAlumnos> GetAlumnos()
        {
            await _inputPort.Handle();
            return _presenter.Alumno;
        }
    }
}
