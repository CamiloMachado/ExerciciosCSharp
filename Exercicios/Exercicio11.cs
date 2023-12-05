using System;
using System.Drawing;

namespace ExerciciosCSharp.Exercicios {
    // Ler dois valores inteiros para as variáveis A e B, efetuar a troca dos valores de modo que a variável A passe a
    // possuir o valor da variável B, e a variável B passe a possuir o valor da variável A.
    // Apresentar os valores trocados.

    internal class Exercicio11 {

        public static void Executar() {
            // Variáveis
            int A = 7;
            int B = 3;
            int C = 0;

            Console.WriteLine($"Valor A: {A}");
            Console.WriteLine($"Valor B: {B}");

            // Troca de valores entre A e B e C.
            C = A;
            A = B;
            B = C;

            Console.WriteLine($"Valor A: {A}");
            Console.WriteLine($"Valor B: {B}");
        }
    }
}
