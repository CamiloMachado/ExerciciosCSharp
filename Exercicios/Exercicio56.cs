// Fazer um programa para ler um vetor de inteiros positivos de 50 posições.
// Imprimir a quantidade de números pares e de múltiplos de 5.

namespace ExerciciosCSharp.Exercicios {

    internal class Exercicio56 {

        public static void Executar() {
            // Criado as variáveis
            uint numPar = 0, numMultiploDeCinco = 0;
            uint posicoes = 50;
            int[] vetor = new int[posicoes];

            // Usado o Radom para gerar números aleatórios
            Random randNum = new();

            // Laço para fazer a criação dos números nas poisções do vetor, validação das condições e guarda na variável.
            for (uint i = 0; i < posicoes; i++) {
                vetor[i] = randNum.Next(1, 101);
                if (vetor[i] % 2 == 0) {
                    numPar++;
                }
                if (vetor[i] % 5 == 0) {
                    numMultiploDeCinco++;
                }
            }

            // Imprime os dados solicitados
            Console.WriteLine("Quantidade de números pares é: {0}.", numPar);
            Console.WriteLine("Quantidade de números múltiplos de cinco é: {0}.", numMultiploDeCinco);
        }
    }
}
