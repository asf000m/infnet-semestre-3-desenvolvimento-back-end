package br.edu.infnet.model;

public class Evento {
    private String nome;
    private String local;
    private int capacidade;
    private int qtdInscritos;
    
    
    public Evento(String nome, String local, int capacidade) {
        this.nome = nome;
        this.local = local;

        if (capacidade > 0)
            this.capacidade = capacidade;
    }

    public boolean temVaga() {
        return qtdInscritos < capacidade;
    }

    public void inscrever() {
        if (temVaga())
            qtdInscritos++;
    }

    @Override 
    public String toString() {
        return String.format("nome=%s; local=%s; capacidade=%d; qtdInscritos=%d",
            nome, 
            local, 
            capacidade, 
            qtdInscritos);
    }
}
