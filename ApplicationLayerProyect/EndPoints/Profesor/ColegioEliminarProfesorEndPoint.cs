using ApplicationLayerProyect.Interfaces.Controladores.Interfaces.Profesor;
using Microsoft.Graph.Models;

namespace ApplicationLayerProyect.EndPoints.Profesor
{
    public static class ColegioEliminarProfesorEndPoint
    {
        public static WebApplication DeleteProfesorEndPoint(this WebApplication app)
        {
            app.MapPut("/profesor/delete/{id}", async (IDeleteProfesorController controller, int id) =>
            {
                var profesor = await controller.DeleteProfesor(id);
                if (profesor == null)
                {
                    return Results.StatusCode(StatusCodes.Status500InternalServerError);
                }
                else if (profesor.ErrorNumber != 0 && !string.IsNullOrEmpty(profesor.Mensaje))
                {
                    return Results.BadRequest(profesor);
                }

                return Results.Ok(profesor);
            });
            return app;
        }

    }
}
