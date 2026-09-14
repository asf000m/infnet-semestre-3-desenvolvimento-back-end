namespace Exercicio09;

class Program
{
    static void Main(string[] args)
    {
        Matricula matricula001 = new();

        matricula001.NomeDoAluno = "Fulano";
        matricula001.Curso = "Robótica";
        matricula001.NumeroMatricula = 1;
        matricula001.Situacao = "Ativa";
        matricula001.DataInicial = "2026-09-01";

        matricula001.ExibirInformacoes();
        Console.WriteLine();

        matricula001.Trancar();
        matricula001.ExibirInformacoes();
        Console.WriteLine();

        matricula001.Reativar();
        matricula001.ExibirInformacoes();
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
            $"Nome:\t\t{NomeDoAluno}\nCurso:\t\t{Curso}\n" +
            $"Situação:\t{Situacao}\nData inicial:\t{DataInicial}"
        );
    }
}