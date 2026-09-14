public class Exercicio07 {
    public static void main(String[] args) {
        Conta1 conta001 = new Conta1();
        conta001.titular = "Funalo Sicrano";
        conta001.numero = 1;
        conta001.agencia = "0001";
        conta001.saldo = 100;
        conta001.dataAbertura = "2026-09-06";
    }
}


class Conta1 {
    String titular;
    int numero;
    String agencia;
    double saldo;
    String dataAbertura;
}