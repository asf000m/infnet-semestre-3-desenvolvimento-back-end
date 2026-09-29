namespace Exercicio10;

class Program
{
    static void Main(string[] args)
    {
        const int MIN = 1, MAX = 50, TENTATIVAS = 5;
        
        Random rnd = new Random();
        int rndInt = rnd.Next(MIN, MAX);


        for (int i = 0; i < TENTATIVAS; i++)
        {
            Console.Write("Adivinhe um número inteiro de 1 a 50: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero == rndInt)
            {
                Console.WriteLine("Você acertou!");
                break;
            }
            else if (i == 3)
                Console.WriteLine("Falta apenas uma tentativa...\n");
            
            if (i < 4)
                Console.WriteLine("Tente novamente...\n");
        }
    }
}
