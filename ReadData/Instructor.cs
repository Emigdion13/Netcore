namespace ReadData
{
    public class Instructor
    {

        public int InstructorId{get; set;}

        public string Nombre {get; set;}
        public string Apellidos {get; set;}
        public string Grado {get; set;}
        public byte[] FotoPerfil {get; set;}

        public ICollection<CursoInstructor> CursosLink {get; set;}
        
    }
}