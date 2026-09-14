
import java.util.Scanner;

public class Exercicio03 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        double cambioDolar = 0.19;
        double cambioEuro = 0.17;
        double cambioLibra = 0.14;

        System.out.println("Informe o valor em Reais para conversão:");
        double reais = sc.nextDouble();

        sc.nextLine();  // limpa buffer
        
        System.out.println("\nInforme a moeda de destino:");
        System.out.println("Dólar\tEuro\tLibra");
        String moedaDestino = sc.nextLine().toLowerCase();

        double resultado;
        if (moedaDestino.equals("dolar") || moedaDestino.equals("dólar"))
            resultado = reais * cambioDolar;
        else if (moedaDestino.equals("euro"))
            resultado = reais * cambioEuro;
        else if (moedaDestino.equals("libra"))
            resultado = reais * cambioLibra;
        else
            resultado = 0;

        if (resultado != 0)
            System.out.printf("\n%.2f", resultado);
        else
            System.out.println("Moeda de destino inválida.");

        sc.close();
    }
}
