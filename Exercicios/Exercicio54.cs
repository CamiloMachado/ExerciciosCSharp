//  Dado dois vetores, A (5 elementos) e B (8 elementos), faça um programa em C# que imprima
//  todos os elementos comuns aos dois vetores.

using System.Globalization;

namespace ExerciciosCSharp.Exercicios {

    internal class Exercicio54 {

        public static void Executar() {
            // Criação dos vetores
            string[] vetorA = ["a", "b", "c", "d", "e"];
            string[] vetorB = ["g", "h", "e", "f", "k", "l", "c", "t", "u"];

            // Laço dentro de laço onde será percorrido os vetores e verificado se os elementos são iguais.
            foreach (string vA in vetorA) {
                foreach (string vB in vetorB) {
                    if (vA.Equals(vB)) {
                        Console.WriteLine("Elemento comum aos dois vetores: {0}.", vB);
                    }
                }
            }
        }
    }
}
