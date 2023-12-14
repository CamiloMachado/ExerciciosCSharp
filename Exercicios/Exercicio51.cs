// Fazer um programa para ler uma quantidade N de alunos.
// Ler a nota de cada um dos N alunos e calcular a média aritmética das notas.
// Contar quantos alunos estão com a nota acima de 7.0.
// Obs.: Se nenhum aluno tirou nota acima de 5.0, imprimir mensagem: Não há nenhum aluno com nota acima de 5.

namespace ExerciciosCSharp.Exercicios {

    internal class Exercicio51 {

        public static void Executar() {
            // Criação das variáveis e do array
            double media = 0;
            int maiorQueSete = 0, menorQueCinco = 0;
            double[] notasTurma =
            [
                4,
                3,
                3,
                2,
                1,
                4,
                5,
                2,
                1,
                1,
            ];

            // Laço para guardar a média, verifcar se a nota é maior que 7 ou menor que 5
            foreach (double nota in notasTurma) {
                media += nota;

                if (nota > 7) {
                    maiorQueSete++;
                } else if (nota <= 5) {
                    menorQueCinco++;
                }
            }

            // Imprimi a média e se tiverem notas > 7 ou se todas forem < 5.
            Console.WriteLine("A média dos aluns é: {0}.", (media / 10).ToString("F1"));
            if (maiorQueSete > 0) {
                Console.WriteLine($"A quantidade de alunos com nota maior que sete é: {maiorQueSete}.");
            } else if (menorQueCinco == 10) {
                Console.WriteLine("Não há nenhum aluno com nota acima de 5.");
            }
        }
    }
}
