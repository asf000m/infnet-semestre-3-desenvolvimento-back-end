namespace Encapsulamento2.Models
{
    public class Conta
    {
        private int id;
        private String nome;
        private double saldo;

        public void SetId(int id)
        {
            this.id = id;
        }

        public int GetId()
        {
            return id;
        }


        public void SetNome(String nome)
        {
            this.nome = nome;
        }

        public String GetNome()
        {
            return nome;
        }


        public void SetSaldo(double saldo)
        {
            this.saldo = saldo;
        }

        public double GetSaldo()
        {
            return saldo;
        }
    }
}