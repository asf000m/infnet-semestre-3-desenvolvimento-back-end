namespace Exercicio01;

/*
Uma classe é um modelo que define a forma de um objeto da realidade.
Nela são definidos os dados e ações que fazem parte do objeto. 

Por exemplo, uma classe Veiculo pode ser criada para criar objetos que
representam um veículo, com os dados sendo as caracteríticas gerais de
todos os veículos e suas ações são os metodos que manipulam esses dados.
*/

class Program
{
    static void Main()
    {
        // Cria um novo objeto da classe Carro.
        Veiculo carro = new();
        
        // Insere os atributos para o objeto criado.
        carro.tipo = "carro";
        carro.fabricante = "toyota";
        carro.modelo = "supra";
        carro.ano = 2021;

        // Chama um método na classe do objeto e utiliza os atributos.
        carro.ExibirInformacoes();
    }
}

class Veiculo
{
    // Os atributos são os dados que o objeto armazena e que são definidos pela
    // classe.
    public String tipo;
    public String fabricante;
    public String modelo;
    public int ano;


    // Os métos são as ações que são feitas para manipularem os atributos.
    public void ExibirInformacoes()
    {
        Console.WriteLine(
            $"Tipo:\t\t{tipo.ToUpper()}\nFabricante:\t{fabricante}\n" +
            $"Modelo:\t\t{modelo}\nAno:\t\t{ano}"
        );
    }
}

