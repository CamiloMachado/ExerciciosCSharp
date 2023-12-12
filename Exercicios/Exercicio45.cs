// Dada uma seqüência de n números (vetor de inteiros), imprimi-lá na ordem inversa que foi realizada a leitura.

namespace ExerciciosCSharp.Exercicios {

    internal class Exercicio45 {

        public static void Executar() {
            // Criado o array que será usado como vetor
            uint[] vetor =
            [
                4,
                10,
                8,
                5,
                1,
                7,
                2,
                9,
                3,
                11,
            ];

            // Aqui é feito a inversão do array
            foreach (var v in vetor.Reverse()) {
                Console.WriteLine(v);
            }
        }
    }
}
