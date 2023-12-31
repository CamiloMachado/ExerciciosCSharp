﻿namespace ExerciciosCSharp.Exercicios {
    // Escreva um programa que leia dois números e exiba mensagem informando o valor do maior número e o valor do menor número.
    // Se os dois números forem iguais, o programa deve exibir mensagem informando este fato.

    internal class Exercicio16 {

        public static void Executar() {
            // Solicitando os valores
            Console.WriteLine("Digite um número:");
            _ = int.TryParse(Console.ReadLine(), out int num1);
            Console.WriteLine("\nDigite outro número:");
            _ = int.TryParse(Console.ReadLine(), out int num2);

            // validando os números
            if (num1 == num2) {
                // Iguais
                Console.WriteLine("\nOs número são iguais.");
            } else if (num1 > num2) {
                Console.WriteLine($"\nO maior número é {num1} e o menor é {num2}.");
            } else {
                Console.WriteLine($"\nO maior número é {num2} e o menor é {num1}.");
            }
        }
    }
}
