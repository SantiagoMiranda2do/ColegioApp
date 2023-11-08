using ApplicationLayerProyect.Interfaces.Controladores.Interfaces.Profesor;
using Microsoft.Graph.Models;

namespace ApplicationLayerProyect.EndPoints.Profesor
{
    public static class ColegioAllProfesoresEndPoint
    {
        public static WebApplication GetAllProfesorEndPoint(this WebApplication app)
        {
            app.MapGet("/profesor", async (IGetAllProfesorController controller) =>
            {
                var profesores = await controller.GetProfesores();

                if (profesores == null)
                {
                    return Results.StatusCode(StatusCodes.Status500InternalServerError);
                }
                else if (profesores.NumeroError != 0 && !string.IsNullOrEmpty(profesores.Mensaje))
                {
                    return Results.BadRequest(profesores);
                }
                else
                {
                    return Results.Ok(profesores);
                }
            });

            return app;
        }

    }
}
