// Leia 2 vetores de inteiros V1 e V2 de N componentes cada (no máximo 50).
// Determine e imprima quantas vezes que V1 e V2 possuem valores idênticos nas mesmas posições.

namespace ExerciciosCSharp.Exercicios {

    internal class Exercicio49 {

        public static void Executar() {
            // Criação dos vetores e variável que vai guardar o total de vezes
            uint[] V1 = [5, 3, 4, 6, 1];
            uint[] V2 = [5, 2, 4, 0, 1];
            uint V1IgualV2 = 0;

            // Laço que irá percorrer os vetores e verificar em qual posição eles são idênticos
            for (uint i = 0; i < V1.Length; i++) {
                if (V1[i] == V2[i]) {
                    V1IgualV2++;
                }
            }

            // Imprime quantas vezes eles são idênticos
            Console.WriteLine("V1 e V2 possuem valores idênticos na mesma posição {0} vezes.", V1IgualV2);
        }
    }
}
