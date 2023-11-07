using ApplicationLayerProyect.Envoltorios.Profesores;
using ApplicationLayerProyect.Interfaces.Controladores.Interfaces.Profesor;
using ApplicationLayerProyect.Interfaces.Getways.ProfesorGetways.InputPutProfesor;
using ApplicationLayerProyect.Interfaces.Presentadores.PresentadoresProfesor;

namespace ApplicationLayerProyect.Controladores.ControladoresProfesor
{
    public class ObtenerProfesorPorIdControlador : IGetProfesorByIdController
    {
        readonly IGetProfesorByIdInputPort _inputPort;
        readonly IGetProfesorByIdPresenter _presenter;


        public ObtenerProfesorPorIdControlador(IGetProfesorByIdInputPort inputPort, IGetProfesorByIdPresenter presenter)
        {

            _inputPort = inputPort;
            _presenter = presenter;


        }
        async Task<EnvoltorioSeleccionarProfesor> IGetProfesorByIdController.GetProfesor(int IdProfesor)
        {
            await _inputPort.Handle(IdProfesor);
            return _presenter.Profesor;
        }


    }
}
