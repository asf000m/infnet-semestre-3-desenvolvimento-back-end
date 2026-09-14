import java.util.Scanner;

public class Exercicio11 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.print("Informe um valor inicial: ");
        double inicial = sc.nextDouble();

        System.out.print("Informe um valor de incremento: ");
        double incremento = sc.nextDouble();

        for (double i = inicial; i <= 100; i += incremento)
            System.out.println(i);

        sc.close();
    }
}
