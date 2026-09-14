package br.edu.infnet.fundamentos;

public class PerfilFormatado {
    public static void main(String[] args) {
        Profissional profissional = new Profissional();

        profissional.nome = "Asafe Maia";
        profissional.profissao = "Programador";
        profissional.idade = 27;

        profissional.estado = "Maranhão";
        profissional.altura = 1.82;
        profissional.professor = false;

        profissional.cidade = "Buriticupu";
        profissional.salario = 4444.14;
        profissional.empresa = "Dataprev";

        profissional.imprimir();
    }
}
