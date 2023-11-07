using ApplicationLayerProyect.Envoltorios.Profesores;
using ApplicationLayerProyect.Interfaces.Presentadores.PresentadoresProfesor;
using DomainLayerProject.Entidades;

namespace ApplicationLayerProyect.Presentadores.PresentadoresProfesor
{
    public class ObtenerTodosProfesoresPresentador : IGetAllProfesoresPresenter
    {
        public EnvoltorioSeleccionarTodosProfesores Profesor { get; private set; }

        public ValueTask Handle(EnvoltorioSeleccionarTodosProfesores alumnos)
        {
            //foreach (var profesor in Profesores)
            //{
            //    Profesores.Append(new EnvoltorioSeleccionarProfesor
            //    {
            //        IdProfesor = profesor.IdActor,
            //        NombreProfesor = profesor.NombreActor,
            //        NumeroError = profesor.ErrorNumber,
            //        Mensaje = string.IsNullOrEmpty(profesor.Message) ? "" : profesor.Message
            //    });
            //}

            Profesores = profesores;
            return ValueTask.CompletedTask;
        }
    }
}
