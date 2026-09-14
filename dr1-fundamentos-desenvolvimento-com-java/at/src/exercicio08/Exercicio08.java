package exercicio08;

public class Exercicio08 {
    public static void main(String[] args) {
        Gerente gerente = new Gerente();
        gerente.nome = "Fulano";
        
        System.out.println("Salário de gerente: R$ " + gerente.salario);

        Estagiario estagiario = new Estagiario();
        estagiario.nome = "Siclano";

        System.out.println("Salário de estagiário: R$ " + estagiario.salario);
    }
}


class Funcionario {
    String nome;
    static double salarioBase = 2000;
}


class Gerente extends Funcionario {
    double salario = salarioBase * 1.2;
}


class Estagiario extends Funcionario {
    double salario = salarioBase * 0.9;
}