// Dados dois vetores x e y, ambos com n elementos, determinar o produto escalar desses vetores.
// Ou seja, realizar a soma de todos dos resultados da multiplicação de x[i] por y[i].

namespace ExerciciosCSharp.Exercicios {

    internal class Exercicio46 {

        public static void Executar() {
            // Declaração dos vetores
            int[] vetorX = [1, 2, 3];

            int[] vetorY = [1, 2, 3];

            // Variáveis onde vão ser guardado os valores.
            int soma;
            int somaTotal = 0;

            // Laço para fazer o calculo dos resultados das multiplicações dos vetores x e y.
            for (int i = 0; i < vetorX.Length; i++) {
                soma = vetorX[i] * vetorY[i];
                somaTotal += soma;
            }

            // Imprime o total
            Console.WriteLine("Soma: {0}", somaTotal);
        }
    }
}
