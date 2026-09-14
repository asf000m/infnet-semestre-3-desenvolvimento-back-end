namespace Exercicio08;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

class Matricula
{
    public String NomeDoAluno;
    public String Curso;
    public int NumeroMatricula;
    public String Situacao;
    public String DataInicial;


    public void Trancar()
    {
        Situacao = "Trancada";
    }

    public void Reativar()
    {
        Situacao = "Ativa";
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine(
            $"Nome:\t{NomeDoAluno}\nCurso:\t{Curso}\n" +
            $"Situação:\t{Situacao}\nData inicial\t{DataInicial}"
        );
    }
}