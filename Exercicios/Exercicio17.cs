using System;

namespace ExerciciosCSharp.Exercicios {
    // Escreva um programa que leia um número inteiro.
    // Verificar por meio de condição, se o valor fornecido está na faixa entre 0 (zero) e 9 (nove).
    // Caso o valor fornecido esteja dentro da faixa, apresentar a mensagem “valor válido”.
    // Caso contrário, apresentar a mensagem “valor inválido”.

    internal class Exercicio17 {

        public void Executar() {
            //Solicitando um número
            Console.WriteLine("Digite um número: ");
            int.TryParse(Console.ReadLine(), out int num);

            //validando se o número está entre 0 e 9
            if (num >= 0 && num <= 9) {
                Console.WriteLine("\nValor válido!");
            } else {
                Console.WriteLine("\nValor inválido!");
            }
        }
    }
}
