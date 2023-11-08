using ApplicationLayerProyect.Interfaces.Controladores.Interfaces.Profesor;
using DomainLayerProject.DTOs.Request.RequestProfesor;
using Microsoft.Graph.Models;

namespace ApplicationLayerProyect.EndPoints.Profesor
{
    public static class ColegioCrearProfesorEndPoint
    {
        public static WebApplication CreateProfesorEndPoint(this WebApplication app)
        {
            app.MapPost("/create", async (CrearProfesorRequest request, ICreateProfesorController controller) =>
            {
                var result = await controller.CreateProfesor(request);

                if (!string.IsNullOrEmpty(result.Mensaje) || result.ValidationErrors != null)
                {
                    return Results.BadRequest(result);
                }
                else
                {
                    return Results.Ok(result);
                }
            });

            return app;
        }


    }
}
