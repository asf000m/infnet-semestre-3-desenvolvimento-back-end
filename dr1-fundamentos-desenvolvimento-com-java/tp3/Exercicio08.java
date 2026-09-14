public class Exercicio08 {
    public static void main(String[] args) {
        Conta2 conta001 = new Conta2();
        conta001.titular = "Funalo Sicrano";
        conta001.numero = 1;
        conta001.agencia = "0001";
        conta001.saldo = 100;
        conta001.dataAbertura = "2026-09-06";
    }
}

class Conta2 {
    String titular;
    int numero;
    String agencia;
    double saldo;
    String dataAbertura;


    public void saca(double valor) {
        if (saldo > 0 && saldo > valor)
            saldo -= valor;
    }

    public void deposita(double valor) {
        saldo += valor;
    }

    public double calculaRendimento() {
        return saldo * 0.1;
    }
}