using DomainLayerProject.DTOs.DTOValidacion;

namespace DomainLayerProject.Especificaciones
{
    public class TelefonoEspecificacion<T>
    {
        public List<string> ErrorMessage => throw new NotImplementedException();

        public bool IsSatisfiedBy(T entity)
        {
            throw new NotImplementedException();
        }

        private bool EsTelefonoValido(int c)
        {
            foreach (char c in Telefono)
            {
                if (char.IsLetter(c))
                {
                    validationErrors.Add(new ValidacionDTO
                    {
                        PropertyName = "Telefono",
                        ErrorMessage = "Ingrese su numero de telefono correctamente."
                    });
                    return false;
                }
            }
            return true;







        }
    }
}
