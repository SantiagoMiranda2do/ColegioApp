using ApplicationLayerProyect.Envoltorios.Profesores;
using ApplicationLayerProyect.Interfaces.Controladores.Interfaces.Profesor;
using ApplicationLayerProyect.Interfaces.Getways.ProfesorGetways.InputPutProfesor;
using ApplicationLayerProyect.Interfaces.Presentadores.PresentadoresProfesor;

namespace ApplicationLayerProyect.Controladores.ControladoresProfesor
{
    public class ObtenerTodosProfesoresControlador : IGetAllProfesorController
    {

        readonly IGetAllProfesoresInputPort _inputPort;
        readonly IGetAllProfesoresPresenter _presenter;


        public ObtenerTodosProfesoresControlador(IGetAllProfesoresInputPort inputPort, IGetAllProfesoresPresenter presenter)
        {

            _inputPort = inputPort;
            _presenter = presenter;


        }

        public async ValueTask<EnvoltorioSeleccionarTodosProfesores> GetProfesores()
        {
            await _inputPort.Handle();
            return _presenter.Profesor;
        }




    }
}
