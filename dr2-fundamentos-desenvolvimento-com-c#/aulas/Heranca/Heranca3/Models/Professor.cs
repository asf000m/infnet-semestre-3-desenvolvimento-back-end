namespace Heranca3.Models;

public class Professor : Pessoa
{
    public String Titulacao {get; set;}


    public Professor(int id, String nome, String endereco, String telefone, String titulacao) : base(id, nome, endereco, telefone)
    {
        if (String.IsNullOrEmpty(titulacao))
            throw new ArgumentException("Erro: Curso inválido.");
        Titulacao = titulacao;
    }
}