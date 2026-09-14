import java.util.Scanner;

public class HelloWorld {
    public static void main() {
        Scanner sc = new Scanner(System.in);

        System.out.println("Informe seu nome e idade:");
        String nome = sc.nextLine();
        int idade = sc.nextInt();

        System.out.println("Nome: " + nome + ", Idade: " + idade);
    }
}

