namespace Heranca2.Models;

public abstract class Pessoa
{
    public int Id {get; set;}
    public String Nome {get; set;}
    public String Endereco {get; set;}
    public String Telefone {get; set;}


    public Pessoa(int id, String nome, String endereco, String telefone)
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
        
    }

    public override String ToString()
    {
        return $"{Id} {Nome} {Endereco} {Telefone}";
    }
}