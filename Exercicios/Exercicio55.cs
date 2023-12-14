// Fazer um programa que leia uma frase de até 50 caracteres e imprima a frase sem os espaços em branco.
// Imprimir também a quantidade de espaços em branco da frase.

namespace ExerciciosCSharp.Exercicios {

    internal class Exercicio55 {

        public static void Executar() {
            // Criação da frase e da variável usada para contar o número de espaços na frase
            string frase = "pulvinar sapien et ligula ullamcorper malesuada proin libero";
            int numEspacoNaFrase = 0;

            // Percorre a frase e verifica o número de espaços contido nela.
            foreach (char caracter in frase) {
                if (caracter == ' ') {
                    numEspacoNaFrase++;
                }
            }

            // Imprime a frase retirando o espaço e imprime o número de espaço na frase.
            Console.WriteLine("{0}.", frase.Replace(" ", ""));
            Console.WriteLine("Número de espaços na frase: {0}.", numEspacoNaFrase);
        }
    }
}
