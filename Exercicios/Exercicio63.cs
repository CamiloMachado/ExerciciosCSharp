// Escreva um programa que verifique se um número é par ou ímpar através de um método chamado VERIFICA.
// O método deverá receber um número inteiro (n) e deverá retornar a mensagem “PAR” ou “ÍMPAR”

namespace ExerciciosCSharp.Exercicios {

    internal class Exercicio63 {

        // Método irá fazer a analise se o valor inteiro informa é par ou ímpar e retorna uma string
        private static string ParOuImpar(int n) {
            if (n % 2 == 0) {
                return "par";
            } else {
                return "ímpar";
            }
        }

        public static void Executar() {
            // Solictado o valor ao usuário que será analisado
            Console.WriteLine("Bem vindo!");
            Console.WriteLine("Programa par ou ímpar!");
            Console.Write("Informe o valor que deseja analisar: ");
            _ = int.TryParse(Console.ReadLine(), out int n);

            // Chama o método e guarda o reultado na variável
            string parOuImpar = ParOuImpar(n);

            Console.WriteLine("");

            // Imprima a string, conforme o analisado.
            Console.WriteLine("O valor informado é {0}!", parOuImpar);
        }
    }
}
