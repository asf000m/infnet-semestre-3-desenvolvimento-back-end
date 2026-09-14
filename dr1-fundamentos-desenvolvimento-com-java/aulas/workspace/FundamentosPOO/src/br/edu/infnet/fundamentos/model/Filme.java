package br.edu.infnet.fundamentos.model;

public class Filme {
    
    private String titulo;
    private int ano;
    private double avaliacao;


    public Filme(String titulo, int ano) {
        this.titulo = titulo;
        this.ano = ano;
    }



    public String getTitulo() {
        return titulo;
    }

    public int getAno() {
        return ano;
    }

    
    public void impressao() {
        double notaEmEstrelas = calcularNotaEmEstrelas();
        
        System.out.printf("O filme %s lançado em %d teve avaliação %.2f.\n", titulo, ano, avaliacao);
        System.out.println("Estrelas: " + notaEmEstrelas);
    }
    
    public void exibirResumo() {
        System.out.println(titulo + " (" + ano + ")");
    }
    
    private double calcularNotaEmEstrelas() {
        return avaliacao / 2;
    }

    public void avaliar(double avaliacao) {
        if (avaliacao < 0 || avaliacao > 10) {
            System.err.println("Nota inválida!");
            return;
        }
        
        this.avaliacao = avaliacao;

    }
}
