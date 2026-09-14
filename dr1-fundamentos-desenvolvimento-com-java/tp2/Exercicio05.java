import java.util.Scanner;

public class Exercicio05 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.println("Informe o valor da compra:");
        double valorCompra = sc.nextDouble();

        double percDesconto;
        if (valorCompra > 1_000)
            percDesconto = 10.0;
        else if (valorCompra > 500)
            percDesconto = 5.0;
        else
            percDesconto = 0;

        double desconto = valorCompra * (percDesconto / 100);
        double valorFinal = valorCompra - desconto;

        String mensagem = "Valor original: $ " + valorCompra;
        mensagem += "\nDesconto aplicado: $ " + desconto;
        mensagem += "\nValor final: $ " + valorFinal;

        System.out.println(mensagem);

        sc.close();
    }
}
