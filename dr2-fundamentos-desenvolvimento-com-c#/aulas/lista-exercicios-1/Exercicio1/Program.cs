// Apresentação pessoal
// Solicite Nome, Idade e Cidade e exiba as informações.

Console.WriteLine("Informe seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine("Informe sua idade: ");
int idade = int.Parse(Console.ReadLine());

Console.WriteLine("Informe sua cidade: ");
string cidade = Console.ReadLine();

Console.WriteLine($"Nome: {nome}");
Console.WriteLine($"Idade: {idade}");
Console.WriteLine($"Cidade: {cidade}");