using ApplicationLayerProyect.Envoltorios.Alumnos;
using ApplicationLayerProyect.Interfaces.Controladores.Interfaces.Alumno;
using ApplicationLayerProyect.Interfaces.Getways.AlumnoGetways.InputPortAlumno;
using ApplicationLayerProyect.Interfaces.Presentadores.PresentadoresAlumno;

namespace ApplicationLayerProyect.Controladores.ControladoresAlumno
{
    public class ObtenerAlumnoPorIdControlador : IGetAlumnoByIdController
    {

        readonly IGetAlumnoByIdInputPort _inputPort;
        readonly IGetAlumnoByIdPresenter _presenter;


        public ObtenerAlumnoPorIdControlador(IGetAlumnoByIdInputPort inputPort, IGetAlumnoByIdPresenter presenter)
        {

            _inputPort = inputPort;
            _presenter = presenter;


        }

        async Task<EnvoltorioSeleccionarAlumno> IGetAlumnoByIdController.GetAlumno(int IdAlumno)
        {
            await _inputPort.Handle(IdAlumno);
            return _presenter.Alumno;
        }
    }
}
