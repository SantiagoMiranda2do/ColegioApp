using ApplicationLayerProyect.Envoltorios.Profesores;
using ApplicationLayerProyect.Interfaces.Controladores.Interfaces.Profesor;
using ApplicationLayerProyect.Interfaces.Getways.ProfesorGetways.InputPutProfesor;
using ApplicationLayerProyect.Interfaces.Presentadores.PresentadoresProfesor;

namespace ApplicationLayerProyect.Controladores.ControladoresProfesor
{
    public class EliminarProfesorControlador : IDeleteProfesorController
    {
        readonly IDeleteProfesorInputPort _inputPort;
        readonly IDeleteProfesorPresenter _presenter;


        public EliminarProfesorControlador(IDeleteProfesorInputPort inputPort, IDeleteProfesorPresenter presenter)
        {

            _inputPort = inputPort;
            _presenter = presenter;


        }


        public async Task<EnvoltorioEliminarProfesor> EliminarProfesor(int IdProfesor)
        {
            await _inputPort.Handle(IdProfesor);
            return _presenter.Profesor;
        }
    }
}
