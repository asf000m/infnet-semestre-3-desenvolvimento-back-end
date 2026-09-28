package exercicio12;

import java.util.Scanner;

public class Exercicio12 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        final int QTD_MENSAGENS = 10;
        final int QTD_MSG_USUARIO = (int) QTD_MENSAGENS / 2;

        String[] msgUsuario1 = new String[QTD_MSG_USUARIO];
        String[] msgUsuario2 = new String[QTD_MSG_USUARIO];

        
        System.out.print("Digite o nome do primeiro usuário: ");
        String usuario1 = sc.nextLine();

        System.out.print("Digite o nome do segundo usuário: ");
        String usuario2 = sc.nextLine();

        for (int i = 0; i < QTD_MSG_USUARIO; i++) {
            System.out.printf("[%s] >> ", usuario1);
            msgUsuario1[i] = sc.nextLine();

            System.out.printf("[%s] >> ", usuario2);
            msgUsuario2[i] = sc.nextLine();
        }

        System.out.println("===== HISTÓRICO DE MENSAGENS =====");
        for (int j = 0; j < QTD_MSG_USUARIO; j++) {
            System.out.printf("%s: %s\n", usuario1, msgUsuario1[j]);
            System.out.printf("%s: %s\n", usuario2, msgUsuario2[j]);
        }
        
        System.out.println("Obrigado por utilizarem o sistema! Boa sorte para vocês! 🚀");

        sc.close();
    }
}
