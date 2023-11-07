using ApplicationLayerProyect.Envoltorios.Alumnos;
using ApplicationLayerProyect.Interfaces.Controladores.Interfaces.Alumno;
using ApplicationLayerProyect.Interfaces.Getways.AlumnoGetways.InputPortAlumno;
using ApplicationLayerProyect.Interfaces.Presentadores.PresentadoresAlumno;
using DomainLayerProject.DTOs.Request.RequestAlumno;

namespace ApplicationLayerProyect.Controladores.ControladoresAlumno
{
    public class CrearAlumnoControlador : ICreateAlumnoController
    {
        readonly ICreateAlumnoInputPort _inputPort;
        readonly ICreateAlumnoPresenter _presenter;


        public CrearAlumnoControlador(ICreateAlumnoInputPort inputPort, ICreateAlumnoPresenter presenter)
        {

            _inputPort = inputPort;
            _presenter = presenter;


        }



        public async Task<EnvoltorioCrearAlumno> CrearAlumno(CrearAlumnoRequest request)
        {
            await _inputPort.Handle(request);
            return _presenter.Alumno;
        }
    }
}
