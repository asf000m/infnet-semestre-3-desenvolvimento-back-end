Console.WriteLine("Informe um valor em graus Celsius:");
double celcius = double.Parse(Console.ReadLine());

double fahrenheit = celcius * 9 / 5 + 32;
double kelvin = celcius + 273.15;

Console.WriteLine($"Fahrenheit: {fahrenheit:F2}\nKelvin: {kelvin:F2}");