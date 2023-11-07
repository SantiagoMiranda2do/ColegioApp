using ApplicationLayerProyect.Envoltorios.Alumnos;
using ApplicationLayerProyect.Interfaces.Controladores.Interfaces.Alumno;
using ApplicationLayerProyect.Interfaces.Getways.AlumnoGetways.InputPortAlumno;
using ApplicationLayerProyect.Interfaces.Presentadores.PresentadoresAlumno;

namespace ApplicationLayerProyect.Controladores.ControladoresAlumno
{
    public class EliminarAlumnoControlador : IDeleteAlumnoController
    {
        readonly IDeleteAlumnoInputPort _inputPort;
        readonly IDeleteAlumnoPresenter _presenter;


        public EliminarAlumnoControlador(IDeleteAlumnoInputPort inputPort, IDeleteAlumnoPresenter presenter)
        {

            _inputPort = inputPort;
            _presenter = presenter;


        }

        public async Task<EnvoltorioEliminarAlumno> EliminarAlumno(int IdAlumno)
        {
            await _inputPort.Handle(IdAlumno);
            return _presenter.Alumno;
        }
    }
}
