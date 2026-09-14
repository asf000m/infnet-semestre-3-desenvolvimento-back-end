// Consumo de Combustível
// Leia distância e litros consumidos e calcule km/l.


Console.WriteLine("Informe a distância e litros consumidos:");
double distancia = double.Parse(Console.ReadLine());
double litros = double.Parse(Console.ReadLine());

double eficiencia = distancia / litros;

Console.WriteLine($"{eficiencia} km/L");