import java.util.Scanner;

public class Exercicio08 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        System.out.println("Informe os comprimentos de três lados de um triângulo:");

        double lado1 = sc.nextDouble();
        double lado2 = sc.nextDouble();
        double lado3 = sc.nextDouble();

        String tipo;

        if (lado1 == lado2 && lado2 == lado3)
            tipo = "equilátero";
        else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            tipo = "isóceles";
        else
            tipo = "escaleno";

        System.out.println("O triângulo informado é do tipo " + tipo);

        sc.close();
    }
}
