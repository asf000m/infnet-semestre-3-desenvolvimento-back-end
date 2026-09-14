using Heranca2.Models;

namespace Heranca2;

class Program
{
    static void Main(string[] args)
    {
        Aluno aluno = new(1, "Asafe", "Brasil", "9628", "Engenharia");
        Console.WriteLine(aluno.ToString());
        
        Funcionario funcionario = new(2, "Fulano", "Brasil", "1554", "Adm");
        Console.WriteLine(funcionario.ToString());
        
        Professor professor = new(3, "Siclano", "Brasil", "2030", "Mestre");
        Console.WriteLine(professor.ToString());
        
    }
}
