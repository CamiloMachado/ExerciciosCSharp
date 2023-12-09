// Escreva um programa que leia um conjunto de números positivos e exiba o menor e o maior.
// Suporemos que o número de elementos deste conjunto não é conhecido, e que um número negativo será utilizado para sinalizar o
// fim dos dados.

namespace ExerciciosCSharp.Exercicios {

    internal class Exercicio34 {

        public static void Executar() {
            // Criação do array conjunto e das variáveis para os totais.
            int[] conjunto = new int[11];
            int menor, maior;

            conjunto[0] = 10;
            conjunto[1] = 5;
            conjunto[2] = 8;
            conjunto[3] = 9;
            conjunto[4] = 3;
            conjunto[5] = 12;
            conjunto[6] = 2;
            conjunto[7] = 4;
            conjunto[8] = 0;
            conjunto[9] = -11;
            conjunto[10] = 1;

            menor = conjunto[0];
            maior = conjunto[0];

            // Aqui vai percorrer o conjunto
            foreach (var num in conjunto) {
                // Teste para verificar se o número é negativo e saí do laco foreach
                if (num < 0) {
                    break;
                } else {
                    // Se o número for positivo, fara o teste para saber se é par ou ímpar
                    if (num > 0 && num > maior) {
                        maior = num;
                    } else if (num < menor) {
                        menor = num;
                    }
                }
            }

            // Mostra o total dos pares e ímpares
            Console.WriteLine("\nO menor número é: {0}", menor);
            Console.WriteLine("O maior número é: {0}", maior);
        }
    }
}
