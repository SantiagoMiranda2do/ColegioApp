using ApplicationLayerProyect.Envoltorios.Profesores;
using ApplicationLayerProyect.Interfaces.Controladores.Interfaces.Profesor;
using ApplicationLayerProyect.Interfaces.Getways.ProfesorGetways.InputPutProfesor;
using ApplicationLayerProyect.Interfaces.Presentadores.PresentadoresProfesor;
using DomainLayerProject.DTOs.Request.RequestProfesor;

namespace ApplicationLayerProyect.Controladores.ControladoresProfesor
{
    public class CrearProfesorControlador : ICreateProfesorController
    {
        readonly ICreateProfesorInputPort _inputPort;
        readonly ICreateProfesorPresenter _presenter;


        public CrearProfesorControlador(ICreateProfesorInputPort inputPort, ICreateProfesorPresenter presenter)
        {

            _inputPort = inputPort;
            _presenter = presenter;


        }


        public async Task<EnvoltorioCrearProfesor> CrearProfesor(CrearProfesorRequest request)
        {
            await _inputPort.Handle(request);
            return _presenter.Profesor;
        }

    }
}
