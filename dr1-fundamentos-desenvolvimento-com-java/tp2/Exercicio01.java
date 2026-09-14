import java.util.Scanner;

public class Exercicio01 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.println("Informe o nome completo e idade:");
        String nomeCompleto = sc.nextLine();
        int idade = Integer.parseInt(sc.nextLine());

        System.out.println("Informe o nome da mãe e do pai:");
        String nomeMae = sc.nextLine();
        String nomePai = sc.nextLine();

        int tamanhoNomeCompleto = nomeCompleto.length();
        int tamanhoNomeMae = nomeMae.length();
        int tamanhoNomePai = nomePai.length();

        String nomeMaior;
        if (tamanhoNomeCompleto > tamanhoNomeMae || 
            tamanhoNomeCompleto > tamanhoNomePai)
            nomeMaior = "sim";
        else
            nomeMaior = "não";

        String saida = "\nNome completo: " + nomeCompleto;
        saida += "\nIdade: " + idade + "\nNome da mãe: " + nomeMae;
        saida += "\nNome do pai: " + nomePai;
        saida += "\nNome completo maior que nome pai ou mãe: " + nomeMaior;
        System.out.println(saida);

        sc.close();
    }
}