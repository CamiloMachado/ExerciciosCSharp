// Durante uma corrida de automóveis com N voltas de duração foram anotados para um piloto, na ordem,
// os tempos registrados em cada volta.

// Fazer um programa para ler os tempos das N voltas, calcular e imprimir:
// i - melhor tempo;
// ii - a volta em que o melhor tempo ocorreu;
// iii - tempo médio das N voltas;

namespace ExerciciosCSharp.Exercicios {

    internal class Exercicio53 {

        public static void Executar() {
            // Criação das variáveis e do vetor para guardar
            double melhorTempo = 0, voltaMelhorTempo = 0, tempoMedio = 0, numDeVoltas = 0;
            double[] voltas =
                [
                    2.00,
                    1.40,
                    1.12,
                    1.05,
                    1.10,
                    1.30,
                    1.25,
                    1.33,
                    1.38,
                    1.11,
                    1.03,
                    1.10,
                    1.33,
                    1.28,
                    1.31,
                    1.32,
                    1.11,
                    1.12,
                    1.14,
                    1.11,
                    1.08,
                    1.02,
                    1.01,
                    1.10,
                    1.05,
                    1.21,
                    1.03,
                    1.02,
                ];

            // Laço para percorrer o vetor e fazer as verificações de melhor tempo, tempo médio e número de voltas
            for (int i = 0; i < voltas.Length - 1; i++) {
                if (melhorTempo == 0) {
                    melhorTempo = voltas[i];
                    voltaMelhorTempo = i;
                } else if (melhorTempo > voltas[i]) {
                    melhorTempo = voltas[i];
                    voltaMelhorTempo = i;
                }
                tempoMedio += voltas[i];
                numDeVoltas = i;
            }

            // Imprime os dados solicitados, melhor tempo, volta onde ocorreu o melhor tempo e tempo médio das voltas.
            Console.WriteLine($"O melhor tempo de volta foi: {melhorTempo}.");
            Console.WriteLine($"A volta onde ocorreu o melhor tempo foi: {voltaMelhorTempo}.");
            Console.WriteLine($"Tempo médio das voltas foi: {(tempoMedio / numDeVoltas):F2}");
        }
    }
}
