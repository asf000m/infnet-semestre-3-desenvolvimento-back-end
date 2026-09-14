import java.util.Scanner;

public class Exercicio09 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.println("Informe uma senha:");
        String senha = sc.nextLine();

        String entrada = "";
        do {
            System.out.println("Informe a senha novamente:");
            entrada = sc.nextLine();

            if (! entrada.equals(senha))
                System.out.println("Senha incorreta!\n");
        }
        while (! entrada.equals(senha));

        System.out.println("Fim");

        sc.close();
    }
}
