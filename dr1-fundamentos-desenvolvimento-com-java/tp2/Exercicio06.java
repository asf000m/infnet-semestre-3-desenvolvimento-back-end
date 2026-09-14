import java.util.Scanner;

public class Exercicio06 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.println("Informe um ano:");
        int ano = sc.nextInt();

        String resultado;
        if ((ano % 4 == 0 && !(ano % 100 == 0)) || ano % 400 == 0)
            resultado = "sim";
        else
            resultado = "não";

        System.out.println("O ano " + ano + " é bissexto? " + resultado);

        sc.close();
    }
}
