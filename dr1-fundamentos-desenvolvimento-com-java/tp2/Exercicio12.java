
import java.util.Scanner;

public class Exercicio12 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.println("Informe uma frase: ");
        String frase = sc.nextLine();

        String[] palavras = frase.split(" ");
        int contador = 0;
        for (String palavra : palavras) {
            contador++;
        }

        System.out.println("\nNúmero de palavras: " + contador);

        sc.close();
    }
}
