// Fazer um programa que sorteie um número de 0 a 100 e que permita que o usuário (sem conhecer o número
//sorteado) tente acertar.
// Caso não acerte, o programa deve imprimir uma mensagem informando se o número sorteado é maior ou menor que a tentativa feita.
// Ao acertar o número, o programa deve imprimir a quantidade de tentativas feitas.

namespace ExerciciosCSharp.Exercicios {

    internal class Exercicio50 {

        public static void Executar() {
            // Criação das variáveis necessárias para o programa
            uint tentativas = 0;
            int palpite = 0;

            // Criação do número aleatório e guarda na variável sorteado.
            Random numero = new Random();
            int sorteado = numero.Next(1, 101);

            Console.WriteLine("Tente acertar o número!");

            while (palpite != sorteado) {
                Console.Write("Informe o seu palpite: ");
                _ = int.TryParse(Console.ReadLine(), out palpite); // Guarda na variável o número informado

                // verifica se o palpite é maior ou menor do que o sorteado
                if (palpite > sorteado) {
                    Console.WriteLine("Número sorteado é menor!");
                } else if (palpite < sorteado) {
                    Console.WriteLine("Número sorteado é maior!");
                }

                Console.WriteLine("");
                tentativas++; // implementa o número de tentativa
            }

            // Impremi o número de tentativa
            Console.WriteLine("Parabens!!!");
            Console.WriteLine("Você acertou o número sorteado {0} em {1} tentativas.", sorteado, tentativas);
        }
    }
}
