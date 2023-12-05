using System;

namespace ExerciciosCSharp.Exercicios {
    // Escreva um programa que leia quatro notas escolares de um aluno e apresentar uma mensagem que o aluno foi aprovado se o valor da média
    // escolar for maior ou igual a 7.
    // Se o valor da média for menor que 7, solicitar a nota do recuperação, somar com o valor da média e obter a nova média.
    // Se a nova média for maior ou igual a 7, apresentar uma mensagem informando que o aluno foi aprovado na recuperação.
    // Se o aluno não foi aprovado, apresentar uma mensagem informando esta condição.
    // Apresentar junto com as mensagens o valor da média do aluno.

    internal class Exercicio15 {

        public static void Executar() {
            //Solicitando as notas do aluno
            Console.Write("Digite as quatro notas do aluno.");
            Console.Write("\nNota 1: ");
            double.TryParse(Console.ReadLine(), out double nota1);
            Console.Write("\nNota 2: ");
            double.TryParse(Console.ReadLine(), out double nota2);
            Console.Write("\nNota 3: ");
            double.TryParse(Console.ReadLine(), out double nota3);
            Console.Write("\nNota 4: ");
            double.TryParse(Console.ReadLine(), out double nota4);

            //Calculando a média
            double media = (nota1 + nota2 + nota3 + nota4) / 4;

            // validando a média e vendo a condição do aluno
            if (media >= 7) {
                // Aprovado
                Console.WriteLine($"\nAluno aprovado, média: {media:F1}");
            } else {
                //Recuperação
                Console.WriteLine("\nAluno de recuperação, nota: {0}", media.ToString("F1"));
                Console.WriteLine("\ndigite a nota da recuperação: ");
                double.TryParse(Console.ReadLine(), out double notaRecuperacao);
                media = (notaRecuperacao + media) / 2;
                if (media >= 7) {
                    // Aprovado na recuperação
                    Console.WriteLine($"\nAluno aprovado na recuperação, nota: {media:F1}");
                } else {
                    //Reprovado na recuperação
                    Console.WriteLine($"\nAluno reprovado, nota {media:F1}");
                }
            }
        }
    }
}
