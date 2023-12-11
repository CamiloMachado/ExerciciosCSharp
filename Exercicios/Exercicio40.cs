// A Secretaria de Meio Ambiente que controla o índice de poluição mantém 03 grupos de indústrias que são
// altamente poluentes do meio ambiente.

// O índice de poluição aceitável varia de 0,05 até 0,25.
// Se o índice sobe para 0,3 as indústrias do 1º grupo são intimadas a suspenderem suas atividades, se o
// índice crescer para 0,4 as industrias do 1º e 2º grupo são intimadas a suspenderem suas atividades,
// se o índice atingir 0,5 todos os grupos devem ser notificados a paralisarem suas atividades.

// Faça um programa que leia o índice de poluição medido e emita a notificação adequada aos diferentes grupos de empresas.
// O algoritmo só deve parar de rodar quando o usuário responder "S" na seguinte pergunta, "Deseja encerrar o programa?".

namespace ExerciciosCSharp.Exercicios {

    internal class Exercicio40 {

        public static void Executar() {
            // Variável terminar o programa
            char parar;

            do {
                //Solicita o valor do índice de Poluição ao usuário
                Console.Write("Digite o índice de poluição: ");
                _ = double.TryParse(Console.ReadLine(), out double indicePoluicao);

                // Faz o teste para qual grupo de empresa será emitido as notificações
                if (indicePoluicao > 0 && indicePoluicao <= 0.25) {
                    Console.WriteLine($"\nA poluição está no nível aceitável!");
                } else if (indicePoluicao >= 0.3 && indicePoluicao <= 0.39) {
                    Console.WriteLine($"\nEmpresas do grupo 1, devem suspender suas atividades!");
                } else if (indicePoluicao >= 0.4 && indicePoluicao <= 0.49) {
                    Console.WriteLine($"\nEmpresas do grupo 1 e grupo 2, devem suspender suas atividades!");
                } else {
                    Console.WriteLine($"\nTodas as empresas, devem suspender suas atividades!");
                }

                // Pergunta se o usuário deseja encerrar o programa
                Console.Write("\nDeseja encerrar o programa?(S/N): ");
                _ = char.TryParse(Console.ReadLine(), out parar);
                Console.WriteLine("");
            } while (parar == 'n' || parar == 'N');
        }
    }
}
