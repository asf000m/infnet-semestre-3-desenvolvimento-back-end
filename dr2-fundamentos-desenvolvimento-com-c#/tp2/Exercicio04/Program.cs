Console.WriteLine("Informe o nome, idade, telefone e email:");
Console.Write("Nome: ");
String nome = Console.ReadLine();
Console.Write("Idade: ");
String idade = Console.ReadLine();
Console.Write("Telefone: ");
String telefone = Console.ReadLine();
Console.Write("Email: ");
String email = Console.ReadLine();

Console.WriteLine($"Nome:\t\t{nome}\nIdade:\t\t{idade}");
Console.WriteLine($"Telefone:\t{telefone}\nEmail:\t\t{email}");