// Cálculo do salário
// Leia valor da hora e horas trabalhadas e calcule o salário bruto.


Console.WriteLine("Informe o valor da hora trabalhada e a quantidade de horas feitas no mês:");
double valorHora = double.Parse(Console.ReadLine());
double horasTrabalhadas = double.Parse(Console.ReadLine());

double salarioBruto = valorHora * horasTrabalhadas;

Console.WriteLine($"Salário bruto no mês: R$ {salarioBruto:F2}");