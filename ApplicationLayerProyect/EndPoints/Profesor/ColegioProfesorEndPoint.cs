using ApplicationLayerProyect.Interfaces.Controladores.Interfaces.Profesor;
using Microsoft.Graph.Models;

namespace ApplicationLayerProyect.EndPoints.Profesor
{
    public static class ColegioProfesorEndPoint
    {
        public static WebApplication GetProfesorEndPoint(this WebApplication app)
        {
            app.MapGet("/profesor/{id}", async (IGetProfesorByIdController controller, int id) =>
            {
                var profesor = await controller.GetProfesor(id);

                if (profesor == null)
                {
                    return Results.StatusCode(StatusCodes.Status500InternalServerError);
                }
                else if (profesor.NumeroError != 0 && !string.IsNullOrEmpty(profesor.Mensaje))
                {
                    return Results.BadRequest(profesor);
                }
                else
                {
                    return Results.Ok(profesor);
                }
            });

            return app;
        }

    }
}
