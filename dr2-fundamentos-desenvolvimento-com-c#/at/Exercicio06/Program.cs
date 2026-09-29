namespace Exercicio06;

class Program
{
    static void Main(string[] args)
    {
        Aluno aluno01 = new();
        aluno01.Nome = "Asafe";
        aluno01.Matricula = "12345";
        aluno01.Curso = "Análise e Desenvolvimento de Sistemas";
        aluno01.Media = 8.9;

        aluno01.ExibirDados();
        string situacao = aluno01.VerificarAprovacao();
        Console.WriteLine($"Situação do aluno: {situacao}");
    }
}


public class Aluno
{
    public string Nome {get; set;}
    public string Matricula {get; set;}
    public string Curso {get; set;}
    public double Media {get; set;}


    public void ExibirDados()
    {
        Console.WriteLine(
            $"Dados do aluno:\n" +
            $"\tNome: {Nome}\n" +
            $"\tMatrícula: {Matricula}\n" +
            $"\tCurso: {Curso}\n" +
            $"\tMédia das Notas: {Media}"
        );
    }

    public string VerificarAprovacao()
    {
        if (Media >= 7)
            return "Aprovado";
        else
            return "Reprovado";
    }
}