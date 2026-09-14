import java.util.Scanner;

public class Exercicio04 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int diaAtual = 24;
        int mesAtual = 8;
        int anoAtual = 2026;

        System.out.println("Informe uma data de nascimento (dia, mês e ano):");
        int diaNascimento = sc.nextInt();
        int mesNascimento = sc.nextInt();
        int anoNascimento = sc.nextInt();

        // Calcula os dias entre os anos completos das datas.
        int anosParaDias = 0;

        for (int ano = anoNascimento + 1; ano < anoAtual; ano++) {
            if (((ano % 4 == 0) && !(ano % 100 == 0)) || (ano % 400 == 0))
                anosParaDias += 366;
            else
                anosParaDias += 365;
        }

        // Calcula os dias da data de nascimento até o final do ano da data de nascimento. Ex.: 15/09/2009 -> X dias até 01/01/2010.
        int diasRestantes = 0;

        for (int mes = mesNascimento + 1; mes <= 12; mes++) {
            switch (mes) {
                case 1: case 3: case 5: 
                case 7: case 8: case 10:
                case 12:
                    diasRestantes += 31;
                    break;
            
                case 4: case 6: case 9:
                case 11:
                    diasRestantes += 30;
                    break;
                
                default:
                    if (((anoNascimento % 4 == 0) && !(anoNascimento % 100 == 0)) || (anoNascimento % 400 == 0))
                        diasRestantes += 29;
                    else
                        diasRestantes += 28;
                    break;
            }
        }
        
        // Adiciona os dias restantes do dia data do nascimento até o mês seguinte. Ex.: 15/09 -> 15 dias até 01/10.
        switch (mesNascimento) {
            case 1: case 3: case 5: 
            case 7: case 8: case 10:
            case 12:
                diasRestantes += 31 - diaNascimento;
                break;
        
            case 4: case 6: case 9:
            case 11:
                diasRestantes += 30 - diaNascimento;
                break;
            
            default:
                if (((anoNascimento % 4 == 0) && !(anoNascimento % 100 == 0)) || (anoNascimento % 400 == 0))
                    diasRestantes += 29 - diaNascimento;
                else
                    diasRestantes += 28 - diaNascimento;
                break;
        }

        // Calcula os dias do início do ano atual até a data final.
        for (int mes = 1; mes < mesAtual; mes++) {
            switch (mes) {
                case 1: case 3: case 5: 
                case 7: case 8: case 10:
                case 12:
                    diasRestantes += 31;
                    break;
            
                case 4: case 6: case 9:
                case 11:
                    diasRestantes += 30;
                    break;
                
                default:
                    if (((anoAtual % 4 == 0) && !(anoAtual % 100 == 0)) || (anoAtual % 400 == 0))
                        diasRestantes += 29;
                    else
                        diasRestantes += 28;
                    break;
            }
        }

        diasRestantes += diaAtual;

        int diasTotais = anosParaDias + diasRestantes;

        System.out.println("Idade total em dias: " + diasTotais);

        sc.close();
    }
}
