namespace Polimorfismo1.Models;

public abstract class Animal
{
    public string Nome {get; set;}


    public Animal() {}
    public Animal(string nome)
    {
        Nome = nome;
    }

    public abstract void EmitirSom();
}