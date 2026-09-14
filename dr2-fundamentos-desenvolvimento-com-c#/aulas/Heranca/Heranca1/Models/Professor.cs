namespace Heranca1.Models;

public class Professor
{
    public int Id {get; set;}
    public String Nome {get; set;}
    public String Endereco {get; set;}
    public String Telefone {get; set;}
    public String Titulacao {get; set;}

    public Professor() {}

    public Professor(int id, String nome, String endereco, String telefone, String titulacao)
    {
        if (id <= 0)
            throw new ArgumentException("Erro: ID tem que ser maior que zero.");
        
        Id = id;

        if (String.IsNullOrEmpty(nome))
            throw new ArgumentException("Erro: Nome inválido.");

        Nome = nome;

        if (String.IsNullOrEmpty(endereco))
            throw new ArgumentException("Erro: Endereço inválido.");

        Endereco = endereco;

        if (String.IsNullOrEmpty(telefone))
            throw new ArgumentException("Erro: Telefone inválido.");

        Telefone = telefone;

        if (String.IsNullOrEmpty(titulacao))
            throw new ArgumentException("Erro: Curso inválido.");

        Titulacao = titulacao;
    }
}