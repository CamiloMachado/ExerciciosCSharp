// Uma agência de publicidade pediu à agência de modelos Luz & Beleza para encontrar uma modelo que tenha
// idade entre 18 e 20 anos para participar de uma campanha publicitária milionária de produtos de beleza.

// Foram inscritas 20 candidatas e, ao se inscreverem, forneceram nome e idade.
// Tais informações foram armazenadas em 2 vetores distintos.

// Faça um programa para imprima o vetor que contém os nomes das candidatas aptas a concorrer a uma vaga para
// a campanha milionária.

namespace ExerciciosCSharp.Exercicios {

    internal class Exercicio48 {

        public static void Executar() {
            // Criação dos vetores
            string[] nomeCandidata = new string[20];
            uint[] idadeCandidata = new uint[20];

            //// Laço para guardar os nomes e idades nos vetores
            for (int i = 0; i < nomeCandidata.Length; i++) {
                Console.Write("Digite o nome da candidata: ");
                nomeCandidata[i] = Console.ReadLine();

                Console.Write($"Digite a idade da candidata {nomeCandidata[i]}: ");
                _ = uint.TryParse(Console.ReadLine(), out idadeCandidata[i]);

                Console.WriteLine("");
            }

            //// Imprime um text, antes de informar os nomes
            Console.WriteLine("As candidatas selecionadas são:");
            Console.WriteLine("");

            //// laço com a verificação da idade e mostra o nome de qual está apta a concorrer
            for (int i = 0; i < idadeCandidata.Length; i++) {
                if (idadeCandidata[i] >= 18 && idadeCandidata[i] <= 20) {
                    Console.WriteLine(nomeCandidata[i]);
                }
            }
        }
    }
}
