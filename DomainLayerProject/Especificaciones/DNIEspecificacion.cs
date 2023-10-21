using DomainLayerProject.DTOs.DTOValidacion;

namespace DomainLayerProject.Especificaciones
{
    public class DNIEspecificacion<t>
    {




        private bool EsDniValido(t entity, string v)
        {

            if (ContieneLetras(v))
            {
                validationErrors.Add(new ValidacionDTO
                {
                    PropertyName = "DNI",
                    ErrorMessage = "El dni ingresado contiene caracteres invalidos."
                });

                return false;
            }


            if (ContienePuntos(string))
            {
                validationErrors.Add(new ValidacionDTO
                {
                    PropertyName = "DNI",
                    ErrorMessage = "El dni ingresado contiene caracteres invalidos."
                });
                return false;
            }



            return true;
        }

        private bool ContieneLetras(string)
        {
            foreach (char c in string)
            {
                if (char.IsLetter(c))
                {
                    return true; // La cadena contiene al menos una letra.
                }
            }
            return false;
        }

        private bool ContienePuntos(string dni)
        {
            return dni.Contains(".");

        }





    }
}
