//Escreva um programa que calcule e exiba a soma dos quadrados dos 20 primeiros números inteiros positivos
// ímpares, a partir do número informado pelo usuário menor que 10 e maior que zero.

namespace ExerciciosCSharp.Exercicios {

    internal class Exercicio32 {

        private static int Somar(int num) {
            int soma = 0;
            int quadrado;

            // Laço para um valor 0 até 19
            for (int i = 0; i < 20;) {
                // Válida se o número é ímpar
                if (num % 2 != 0) {
                    quadrado = num * num; // Somando os quadrados
                    soma += quadrado; // variável recebe as somas

                    i++;// incrementação feita apenas se o número for ímpar
                }

                num++;// incrementação do número escolhido
            }

            return soma;// retorna a soma dos quadrados
        }

        public static void Executar() {
            // Solicita ao usuário um valor
            Console.Write("Escoha um número de 1 até 10: ");
            _ = int.TryParse(Console.ReadLine(), out int num);

            // Testa se o valor está no range desejado, > 0 e < 10
            if (num > 0 && num < 10) {
                int resultado = Somar(num); // Chama o método que vai fazer a soma dos valores e colocar na váriavel
                Console.WriteLine("A soma dos quadrados dos números ímpares é: {0}", resultado);// Mostra o resultado da soma
            } else {
                // Teste para ver se o valor é menor igual a 0 e joga na variável o texto escolhido
                string numInvalido = num <= 0 ? "\nO número escolhido menor igual há 0" : "\nO número escolhido maior igual há 10";
                Console.Write(numInvalido); // Mostra o que foi jogado na variável, pelo texte anterior
            }
        }
    }
}
