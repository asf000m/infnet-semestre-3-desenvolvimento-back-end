namespace Heranca3.Models;

public class Funcionario : Pessoa
{
    public String Cargo {get; set;}


    public Funcionario(int id, String nome, String endereco, String telefone, String cargo) : base(id, nome, endereco, telefone)
    {
        if (String.IsNullOrEmpty(cargo))
            throw new ArgumentException("Erro: Curso inválido.");

        Cargo = cargo;
    }
}