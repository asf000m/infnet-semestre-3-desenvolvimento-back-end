package exercicio09;

public class Exercicio09 {
    public static void main(String[] args) {
        ContaBancaria conta01 = new ContaBancaria();

        conta01.titular = "Fulano Silva";
        conta01.depositar(1000);
        conta01.exibirSaldo();
        
        conta01.depositar(-50);
        conta01.sacar(500);
        conta01.exibirSaldo();

        conta01.sacar(-50);
        conta01.exibirSaldo();
    }
}


class ContaBancaria {
    
    // Attributes
    String titular;
    private double saldo;


    // Methods
    public void depositar(double valor) {
        if (valor >= 0) {
            saldo += valor;
            System.out.printf("Depósito de R$ %.2f realizado com sucesso!\n", valor);
        }
        else {
            System.out.println("Erro: Valor deve ser maior que zero.");
        }
    }

    public void sacar(double valor) {
        if (saldo >= valor && valor >= 0) {
            saldo -= valor;
            System.out.printf("Saque de R$ %.2f realizado com sucesso!\n", valor);
        }
        else {
            System.out.println("Erro: Saldo insuficiente para o saque.");
        }
    }

    public void exibirSaldo() {
        System.out.printf("""
            Titular: %s
            Saldo atual: R$ %.2f
            """
            .formatted(titular, saldo)
        );
    }
}