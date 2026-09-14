namespace Heranca2.Models;

public class Aluno : Pessoa
{
    public String Curso {get; set;}

    
    public Aluno(int id, String nome, String endereco, String telefone, String curso) : base(id, nome, endereco, telefone)
    {
        if (String.IsNullOrEmpty(curso))
            throw new ArgumentException("Erro: Curso inválido.");
        Curso = curso;
    }

    public override String ToString()
    {
        return $"{base.ToString()} {Curso}";
    }
}