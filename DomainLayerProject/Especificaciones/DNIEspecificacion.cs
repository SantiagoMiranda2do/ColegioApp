using DomainLayerProject.DTOs.DTOValidacion;

namespace DomainLayerProject.Especificaciones;



public class DNIEspecificacion<T>
{
    readonly List<ValidacionDTO> _errors = new List<ValidacionDTO>();

    public bool EsDniValido(T entity, string dni)
    {
        if (ContieneCaracteresInvalidos(dni))
        {
            _errors.Add(new ValidacionDTO
            {
                PropertyName = "DNI",
                ErrorMessage = "El DNI ingresado contiene caracteres inválidos."
            });

            return false;
        }

        return true;
    }

    private bool ContieneCaracteresInvalidos(string dni)
    {
        foreach (char c in dni)
        {
            if (char.IsLetter(c) || dni.Contains("."))
            {
                return true; // La cadena contiene caracteres inválidos.
            }
        }
        return false;
    }
}


