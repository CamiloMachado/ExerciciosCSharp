// Escrever um programa que leia um conjunto de números positivos, e exiba se o número lido é par ou ímpar.
// Exiba ao final a soma total dos números pares lidos e também a soma dos números ímpares lidos.
// Suporemos que o número de elementos deste conjunto não é conhecido, e que um número negativo será utilizado para sinalizar o
// fim dos dados.

namespace ExerciciosCSharp.Exercicios {

    internal class Exercicio31 {

        public static void Executar() {
            // Criação do array conjunto e das variáveis para os totais.
            int[] conjunto;
            int totalPar = 0, totalImpar = 0;

            conjunto = new int[10];
            conjunto[0] = 2;
            conjunto[1] = 3;
            conjunto[2] = 4;
            conjunto[3] = 5;
            conjunto[4] = 6;
            conjunto[5] = 7;
            conjunto[6] = -8;
            conjunto[7] = 9;
            conjunto[8] = 10;
            conjunto[9] = 11;

            // Aqui vai percorrer o conjunto
            foreach (var num in conjunto) {
                // Teste para verificar se o número é negativo e saí do laco foreach
                if (num < 0) {
                    break;
                } else {
                    // Se o número for positivo, fara o teste para saber se é par ou ímpar
                    if (num % 2 == 0) {
                        Console.WriteLine($"{num} é par!");
                        totalPar = totalPar + num;
                    } else {
                        Console.WriteLine($"{num} é ímpar!");
                        totalImpar = totalImpar + num;
                    }
                }
            }

            // Mostra o total dos pares e ímpares
            Console.WriteLine("\nA soma total dos números pares é: {0}", totalPar);
            Console.WriteLine("A soma total dos números ímpares é: {0}", totalImpar);
        }
    }
}
