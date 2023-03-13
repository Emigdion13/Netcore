using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace ReadData // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new AppVentaCursosContext())
            {
                var cursos = db.Curso.Include(c => c.InstructorLink).ThenInclude(c => c.Instructor);

                foreach (var curso in cursos)
                {
                    Console.WriteLine(curso.Titulo);

                    foreach (var instructionlink in curso.InstructorLink)
                    {
                        Console.WriteLine($"******** {instructionlink.Instructor.Nombre }");
                    }
                }

            }
        }
    }
}