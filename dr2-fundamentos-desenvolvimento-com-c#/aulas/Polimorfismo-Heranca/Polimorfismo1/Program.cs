using Polimorfismo1.Models;

namespace Polimorfismo1;

class Program
{
    static void Main(string[] args)
    {
        List<Animal> animals = new List<Animal>();
        animals.Add(new Cachorro("Leão"));
        animals.Add(new Gato());
        animals.Add(new Passaro());

        foreach (Animal animal in animals)
        {
            Console.WriteLine(animal.GetType().Name);
            
            if (animal.Nome == null)
                Console.WriteLine("null");
            else
                Console.WriteLine(animal.Nome);

            animal.EmitirSom();
            
            Console.WriteLine();
        }
    }
}
