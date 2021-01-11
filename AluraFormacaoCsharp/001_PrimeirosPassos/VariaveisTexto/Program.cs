using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariaveisTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            string titulo = "Alura Cursos de tecnologia " + 2020;
            string cursosProgramacao = 
@" - .NET 
- Java
- Javascript";
            Console.WriteLine(titulo);
            Console.WriteLine(cursosProgramacao);

            Console.ReadLine();
        }
    }
}
