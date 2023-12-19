namespace ExerciciosCSharp.Exercicios {
    // Escreva um programa que leia três valores para os lados de um triângulo (variáveis A, B e C).
    // Verificar se cada lado é menor que a soma dos outros dois lados.
    // Se sim, saber de A==B e se B==C, sendo verdade o triângulo é eqüilátero;
    // Se não, verificar de A==B ou se A==C ou se B==C, sendo verdade o triângulo é isósceles; e caso contrário, o triângulo será escaleno.
    // Caso os lados fornecidos não caracterizarem um triângulo, avisar a ocorrência.

    internal class Exercicio19 {

        public static void Executar() {
            //Variáveis
            int A = 3;
            int B = 2;
            int C = 4;

            // validando os lados e se é um triângulo válido ou não, não sendo informa.
            if (A < B + C && B < A + C && C < A + B) {
                // validando o tipo de triângulo e informando
                if (A == B && B == C) {
                    Console.WriteLine("Triângulo é equilátero!");
                } else if (A == B || A == C || B == C) {
                    Console.WriteLine("Triângulo é isósceles!");
                } else {
                    Console.WriteLine("Triângulo é escaleno!");
                }
            } else {
                Console.WriteLine("Os lados fornecidos não caracterizam um triângulo!");
            }
        }
    }
}
