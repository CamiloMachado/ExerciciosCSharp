// Escreva um programa que calcule e exiba a média da nota dos alunos de uma turma em uma prova. O número de alunos é desconhecido.
// Os dados de um aluno são: número de matrícula e a sua nota na prova em questão.

namespace ExerciciosCSharp.Exercicios {

    internal class Exercicio33 {

        public static void Executar() {
            // Solicitando o número de alunos na turma
            Console.Write("Digite a quantidade de alunos: ");
            _ = double.TryParse(Console.ReadLine(), out double quantidadeDeAlunos);

            // Criado a lista de alunos e suas notas, variável para fazer soma das notas.
            Dictionary<int, double> turma = [];
            double notaFinal = 0;

            // Adição de alunos na turma
            for (int i = 0; i < quantidadeDeAlunos; i++) {
                Console.Write("\nDigite a nota do aluno matrícula {0}: ", i + 1);
                _ = double.TryParse(Console.ReadLine(), out double notaAluno);
                turma.Add(i + 1, notaAluno);
            }

            foreach (var aluno in turma) {
                //Console.Write("\nMatrícula: {0}", aluno.Key); Mostra o número da matrícula do aluno
                notaFinal += aluno.Value;// Soma as notas
            }

            Console.WriteLine($"\nA média da turma é: {notaFinal / quantidadeDeAlunos:F1}");
        }
    }
}
