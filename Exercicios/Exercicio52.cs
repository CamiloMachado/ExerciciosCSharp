// Fazer um programa ler um vetor de inteiros e positivos e imprimir quantas vezes aparece o número 1, 3 e 4, nesta ordem.
// O vetor terá no máximo 100 posições.
// Sair do programa quando for digitado -1.

namespace ExerciciosCSharp.Exercicios {

    internal class Exercicio52 {

        public static void Executar() {
            // Criação das variáveis e do array vetor
            int num1 = 0, num3 = 0, num4 = 0;
            int[] vetor =
                [
                    1,
                    2,
                    3,
                    4,
                    5,
                    1,
                    2,
                    3,
                    4,
                    5,
                    1,
                    2,
                    -3,
                    -4,
                    5,
                    -1,
                    2,
                    3,
                    4,
                    5,
                ];

            // Laço para varrer o vetor e encontra os números 1, 3 e 4.
            foreach (int v in vetor) {
                if (v == -1) {
                    break;
                } else if (v == 1) {
                    num1++;
                } else if (v == 3) {
                    num3++;
                } else if (v == 4) {
                    num4++;
                }
            }

            // Imprime quantos vezes apareceram os números desejados
            Console.WriteLine("Apareceram {0} números 1.", num1);
            Console.WriteLine("Apareceram {0} números 3.", num3);
            Console.WriteLine("Apareceram {0} números 4.", num4);
        }
    }
}
