namespace Encapsulamento3.Models
{
    public class Conta
    {
        private int id;
        private String nome;
        private double saldo;

        public void SetId(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Erro: Valor do ID inválido.");
            }
            
            this.id = id;
        }

        public int GetId()
        {
            return id;
        }


        public void SetNome(String nome)
        {
            if (String.IsNullOrEmpty(nome) || nome.Length < 2)
            {
                throw new ArgumentException("Erro: Nome inválido.");
            }
            
            this.nome = nome;
        }

        public String GetNome()
        {
            return nome;
        }


        public void SetSaldo(double saldo)
        {
            if (saldo < 0)
            {
                throw new ArgumentException("Erro: Valor do saldo inválido.");
            }

            this.saldo = saldo;
        }

        public double GetSaldo()
        {
            return saldo;
        }
    }
}