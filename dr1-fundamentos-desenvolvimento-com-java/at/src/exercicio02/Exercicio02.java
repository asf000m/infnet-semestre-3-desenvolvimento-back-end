package exercicio02;

import java.util.Scanner;

public class Exercicio02 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        final String ESPECIAIS = "!@#$%^&*()-_=+[]{}|;:',.<>/?~";
        
        boolean senhaValida = false;
        
        String nome;
        String senha;
        
        System.out.print("Informe seu nome: ");
        nome = sc.nextLine(); //sc.nextLine();
        
        do { 
            boolean contemEspeciais = false;
            boolean contemNumeros = false;
            boolean contemMaiusculas = false;

            System.out.print("Informe uma senha: ");
            senha = sc.nextLine(); //sc.nextLine();

            if (senha.length() >= 8) {
                for (char ch : senha.toCharArray()) {
                    if (ESPECIAIS.contains(String.valueOf(ch)))
                        contemEspeciais = true;
                    else if (Character.isDigit(ch))
                        contemNumeros = true;
                    else if (Character.isUpperCase(ch))
                        contemMaiusculas = true;
                }

                if (!contemEspeciais)
                    System.out.println("A senha deve conter pelo menos um caractere especial (@, #, $ etc.)");
                if (!contemNumeros)
                    System.out.println("A senha deve conter pelo menos um número.");
                if (!contemMaiusculas)
                    System.out.println("A senha deve conter pelo menos uma letra maiúscula.");

                senhaValida = contemEspeciais && contemNumeros && contemMaiusculas;
            }
            else 
                System.out.println("A senha deve ter no mínimo 8 caracteres.");
        
        } while (!senhaValida);

        sc.close();
    }
}
