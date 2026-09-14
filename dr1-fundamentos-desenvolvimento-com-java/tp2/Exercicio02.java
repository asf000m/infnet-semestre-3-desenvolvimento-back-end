import java.util.Scanner;

public class Exercicio02 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.println("Informe quatro notas bimestrais:");
        double nota1 = sc.nextDouble();
        double nota2 = sc.nextDouble();
        double nota3 = sc.nextDouble();
        double nota4 = sc.nextDouble();

        double media = (nota1 + nota2 + nota3 + nota4) / 4;
        media = Math.round(media);

        String resultado;
        if (media < 5.0)
            resultado = "reprovado";
        else if (media < 7.0)
            resultado = "recuperação";
        else
            resultado = "aprovado";

        String mensagem = "Resultado da média: " + media;
        mensagem += "\nSituação do aluno: " + resultado;

        System.out.println(mensagem);

        sc.close();
    }
}
