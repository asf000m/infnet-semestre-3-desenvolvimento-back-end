
import java.util.Random;
import java.util.Scanner;

public class Exercicio10 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        Random rand = new Random();
        int randInt = rand.nextInt(101) + 1;

        System.out.println("Informe um palpite de 1 a 100:");
        int palpite = sc.nextInt();

        int tentativas = 1;
        while (palpite != randInt) {
            if (palpite > randInt)
                System.out.println("Palpite muito alto.\n");
            else if (palpite < randInt)
                System.out.println("Palpite muito baixo.\n");

            palpite = sc.nextInt();
            tentativas++;
        }

        System.out.println("Correto! " + tentativas + " tentativas.");

        sc.close();
    }
}
