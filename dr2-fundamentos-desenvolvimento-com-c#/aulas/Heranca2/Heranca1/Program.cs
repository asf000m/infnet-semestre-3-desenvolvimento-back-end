using Heranca1.Models;

namespace Heranca1 { 
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Dados do aluno");
            try {
                Aluno aluno = new Aluno(0, "João", "Rua do João", "2199999991", "ADS");
                Console.WriteLine(aluno.Id);
                Console.WriteLine(aluno.Nome);
                Console.WriteLine(aluno.Endereco);
                Console.WriteLine(aluno.Telefone);
                Console.WriteLine(aluno.Curso);
            }
            catch (ArgumentException ex) {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\nDados do professor");
            try {
                Professor professor = new Professor(1, "LP", "Rua do LP", "2199999992", "Mestre");
                Console.WriteLine(professor.Id);
                Console.WriteLine(professor.Nome);
                Console.WriteLine(professor.Endereco);
                Console.WriteLine(professor.Telefone);
                Console.WriteLine(professor.Titulacao);
            }
            catch (ArgumentException ex) {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\nDados do professor");
            try {
                Funcionario funcionario = new Funcionario(1, "LP", "Rua do LP", "2199999992", "RH");
                Console.WriteLine(funcionario.Id);
                Console.WriteLine(funcionario.Nome);
                Console.WriteLine(funcionario.Endereco);
                Console.WriteLine(funcionario.Telefone);
                Console.WriteLine(funcionario.Cargo);
            }
            catch (ArgumentException ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
