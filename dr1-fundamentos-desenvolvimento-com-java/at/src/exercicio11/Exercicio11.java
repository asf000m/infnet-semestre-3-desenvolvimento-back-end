package exercicio11;

import java.util.Arrays;
import java.util.Scanner;

public class Exercicio11 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        final int QTD_NUMEROS = 6, MIN = 1, MAX = 60;
        int[] numerosAleatorios = new int[QTD_NUMEROS];
        int[] numerosUsuario = new int[QTD_NUMEROS];

        for (int i = 0; i < QTD_NUMEROS; i++) {
            numerosAleatorios[i] = (int) ((Math.random() * (MAX - MIN) + MIN));

            System.out.print("Informe um número de 1 a 60: ");
            numerosUsuario[i] = sc.nextInt();
        }
        
        Arrays.sort(numerosAleatorios);
        Arrays.sort(numerosUsuario);

        boolean acerto;
        int acertos = 0;
        for (int j = 0; j < QTD_NUMEROS; j++) {
            acerto = Arrays.binarySearch(numerosAleatorios, numerosUsuario[j]) > -1;
            if (acerto)
                acertos++;
        }

        System.out.println("Acertos: " + acertos);
        System.out.println("Números aleatórios: " + Arrays.toString(numerosAleatorios));
        System.out.println("Números do usuário: " + Arrays.toString(numerosUsuario));

        sc.close();
    }
}
