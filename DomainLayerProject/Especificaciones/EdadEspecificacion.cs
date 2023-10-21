namespace DomainLayerProject.Especificaciones
{
    public class EdadEspecificacion<t>
    {
        public List<string> ErrorMessage => throw new NotImplementedException();

        public bool IsSatisfiedBy(t entity)
        {
            throw new NotImplementedException();
        }


        private bool EsEnteroValido(string v)
        {
            int edad;
            return int.TryParse(v, out edad);
        }







    }
}
