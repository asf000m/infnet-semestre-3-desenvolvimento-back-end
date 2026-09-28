package br.edu.infnet.garagem.model;

public abstract class Veiculo {

    private String placa;
    private String marca;
    private int ano;


    // Constructors
    public Veiculo(String placa, String marca, int ano) {
        // RF01: rejeitar ano < 1900 e ano > 2026.
        if (ano < 1900 || ano > 2026) {
            throw new IllegalArgumentException("ERRO: Ano do veículo inválido: " + ano);
        }

        this.placa = placa;
        this.marca = marca;
        this.ano = ano;
    }

    // Methods
    public abstract double calcularCustoManutencao();

    public void exibirResumo() {
        System.out.println(this);
    }

    public final void exibirIdentificacao() {
        System.out.println("Exibir ID!");
    }

    @Override 
    public String toString() {
        return String.format("%s - %s - %d", placa, marca, ano);
    }
}
