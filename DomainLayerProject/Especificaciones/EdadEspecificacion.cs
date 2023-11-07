using DomainLayerProject.DTOs.DTOValidacion;

namespace DomainLayerProject.Especificaciones;

public class EdadEspecificacion<T>
{
    readonly List<ValidacionDTO> _errors = new List<ValidacionDTO>();

    public bool EsEdadValida(T entity, int edad)
    {
        if (EsEdadInvalida(edad))
        {
            _errors.Add(new ValidacionDTO
            {
                PropertyName = "Edad",
                ErrorMessage = "La edad ingresada no es válida."
            });

            return false;
        }

        return true;
    }

    private bool EsEdadInvalida(int edad)
    {
        return edad < 0 || edad > 120; // Ejemplo de validación, ajusta según tus requisitos.
    }
}









