Console.WriteLine("Informe o peso e a altura:");
Console.Write("Peso: ");
double peso = double.Parse(Console.ReadLine());
Console.Write("Altura: ");
double altura = double.Parse(Console.ReadLine());

double imc = peso / (altura * altura);
imc = Math.Round(imc, 2);

Console.WriteLine($"Seu IMC é {imc}");

String faixa = "";
if (imc <= 18.5)
    faixa = "abaixo do normal";
else if (imc <= 24.9)
    faixa = "normal";
else if (imc <= 29.9)
    faixa = "sobrepeso";
else if (imc <= 34.9)
    faixa = "obesidade grau I";
else if (imc <= 39.9)
    faixa = "obesidade grau II";
else
    faixa = "obesidade grau III";

Console.WriteLine($"Você está na faixa: {faixa}");