package br.edu.infnet.fundamentos.teste;

import br.edu.infnet.fundamentos.model.Filme;

public class TestaFilme {
    public static void main(String[] args) {
        Filme filmeMatrix = new Filme("Matrix", 1999);
        filmeMatrix.avaliar(9.0);

        filmeMatrix.impressao();
        filmeMatrix.exibirResumo();

        //
        System.out.println();
        //

        Filme filmeInterestelar = new Filme("Interestelar", 2014);
        filmeInterestelar.avaliar(9.5);

        filmeInterestelar.impressao();
        filmeInterestelar.exibirResumo();

        //
        System.out.println();
        //

        Filme outroFilme = new Filme("Avengers", 2012);
        outroFilme.avaliar(-10);
        
        outroFilme.impressao();
        outroFilme.exibirResumo();
    }
}
