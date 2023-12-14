// Fazer um programa que leia uma frase e imprima somente as vogais.

namespace ExerciciosCSharp.Exercicios {

    internal class Exercicio57 {

        public static void Executar() {
            // Criação da variável com a frase.
            string frase = "aliquet sagittis id consectetur purus ut faucibus ";

            // percorre a frase e verifica se supre a condição desejada e imprime.
            foreach (char caracter in frase) {
                if (caracter == 'a' || caracter == 'A' || caracter == 'e' || caracter == 'E'
                    || caracter == 'i' || caracter == 'I' || caracter == 'o' || caracter == 'O'
                    || caracter == 'u' || caracter == 'U') {
                    Console.Write(caracter);
                }
            }
        }
    }
}
