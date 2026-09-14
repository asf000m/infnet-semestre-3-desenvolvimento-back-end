package br.edu.infnet.testes;

import br.edu.infnet.model.Evento;

public class EventoTeste {
    public static void main(String[] args) {
        final int INSCRICOES = 5;
        
        String[] nomes = {"Café Ágil", "Java Day", "Aula de Fundamentos"};
        int[] capacidades = {3, 2, 4};
        
        String[] semInscricoes = new String[15];

        int x = 0;

        for (int i = 0; i < nomes.length; i++) {
            Evento evento = new Evento(nomes[i], "Local", capacidades[i]);
            System.out.println(":: " + evento);

            for (int j = 0; j < INSCRICOES; j++) {
                if (evento.temVaga()) 
                    evento.inscrever();
                else
                    // System.out.println("[" + j + "] sem inscrição do evento " + nomes[i]);
                    semInscricoes[++x] = evento.toString();
            }
        }

        for (String ev : semInscricoes)
            System.out.println("Evento sem inscrição: " + ev);


        Evento ev1 = new Evento("Café Ágil", "Sala 1", 30);
        
        if (ev1.temVaga()) {
            System.out.println("Ainda há vagas.");
            ev1.inscrever();
        }
        
        Evento ev2 = new Evento("Java Day", "Auditório", 100);
        ev2.inscrever();

        Evento ev3 = new Evento("Delphi Day", "Estádio", -200);
        ev3.inscrever();

        System.out.println(ev1);
        System.out.println(ev2);
        System.out.println(ev3);
    }
}
