// Fazer um programa para armazenar em um vetor, vários números inteiros e positivos e calcular a média.
// Imprimir também o maior.
// A quantidade de números lidos será definida pelo usuário.

using System.Security.AccessControl;

namespace ExerciciosCSharp.Exercicios {

    internal class Exercicio58 {

        public static void Executar() {
            // Solicitado ao usuário informar quantos valores serão passados
            Console.Write("Quantos valores serão informados? ");
            _ = uint.TryParse(Console.ReadLine(), out uint posicoes);

            // Criação do vetor e variáveis
            double[] vetor = new double[posicoes];
            double media = 0, maior = -1;

            Console.WriteLine("");

            // Laço para receber os dados do usuário e fazer as validações necessárias, qual o maior e media.
            for (int i = 0; i < posicoes; i++) {
                Console.Write("sendo os valores positivos, informe o {i}º valor: ");
                _ = double.TryParse(Console.ReadLine(), out vetor[i]);

                if (maior < 0) {
                    maior = vetor[i];
                } else if (maior < vetor[i]) {
                    maior = vetor[i];
                }

                if (vetor[i] >= 0) {
                    media += vetor[i];
                }
                Console.WriteLine("");
            }

            // Imprime a media e o maior valor
            Console.WriteLine("A média dos valores informado é: {0}", (media / posicoes).ToString("F1"));
            Console.WriteLine($"O maior valor informado é: {maior}");
        }
    }
}
