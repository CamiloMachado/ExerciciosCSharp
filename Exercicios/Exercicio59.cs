// Escreva um programa que solicite dois caracteres de A a Z ao usuário e imprima o número de caracteres existente
// entre eles.

// Assuma que o usuário digite os 2 caracteres em ordem alfabética.
// Caso não o estejam, emitir mensagem de erro.

// Exemplo: Digite 2 caracteres: j t, O numero de caracteres entre eles é: 9

namespace ExerciciosCSharp.Exercicios {

    internal class Exercicio59 {

        public static void Executar() {
            // Variável
            int numChar = 0;

            // Solicitado ao usuário os caracteres.
            Console.WriteLine("Informe dois caracteres de A até Z na ordem alfabética.");
            Console.Write("\nInforme o 1º caracter: ");
            _ = char.TryParse(Console.ReadLine(), out char char1);
            Console.Write("\nInforme o 2º caracter: ");
            _ = char.TryParse(Console.ReadLine(), out char char2);

            // valida se o que foi digitado está em ordem alfabética, se sim faz o calculo e imprime, se não imprime um erro.
            if (char1 < char2) {
                numChar = (char2 - char1) - 1;// o -1 é para tirar o carater deseja, se não ele é contado.
                Console.WriteLine("\nO numero de caracteres entre eles é: {0}.", numChar);
            } else {
                Console.WriteLine("\nOs caracteres não foram informados em ordem alfabética!");
            }
        }
    }
}
