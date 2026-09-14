using Heranca2.Models;

namespace Heranca2 {
    internal class Program {
        static void Main(string[] args) {
            // Erro: classe abstrata
            // Pessoa pessoa = new Pessoa(1, "Felipe", "Rua do Felipe", "2199999993");

            Console.WriteLine("Dados do aluno");
            try {
                Aluno aluno = new Aluno(1, "João", "Rua do João", "2199999991", "ADS");
                Console.WriteLine(aluno.Id);
                Console.WriteLine(aluno.Nome);
                Console.WriteLine(aluno.Endereco);
                Console.WriteLine(aluno.Telefone);
                Console.WriteLine(aluno.Curso);
                //Console.WriteLine(aluno.ToString());
                Console.WriteLine(aluno);
            }
            catch (ArgumentException ex) {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\nDados do professor");
            try {
                Professor professor = new Professor(2, "LP", "Rua do LP", "2199999992", "Mestre");
                Console.WriteLine(professor.Id);
                Console.WriteLine(professor.Nome);
                Console.WriteLine(professor.Endereco);
                Console.WriteLine(professor.Telefone);
                Console.WriteLine(professor.Titulacao);
                //Console.WriteLine(professor.ToString());
                Console.WriteLine(professor);
            }
            catch (ArgumentException ex) {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\nDados do professor");
            try {
                Funcionario funcionario = new Funcionario(3, "LP", "Rua do LP", "2199999992", "RH");
                Console.WriteLine(funcionario.Id);
                Console.WriteLine(funcionario.Nome);
                Console.WriteLine(funcionario.Endereco);
                Console.WriteLine(funcionario.Telefone);
                Console.WriteLine(funcionario.Cargo);
                //Console.WriteLine(funcionario.ToString());
                Console.WriteLine(funcionario);
            }
            catch (ArgumentException ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
