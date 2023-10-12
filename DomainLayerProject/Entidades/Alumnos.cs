using DomainLayerProject.Entidades.EntidadComun;

namespace DomainLayerProject.Entidades
{
    public class Alumnos : Persona
    {
        public int IdAlumno { get; set; }
        public Curso Nivel { get; set; }
        public int Nota { get; set; }
    }
}
