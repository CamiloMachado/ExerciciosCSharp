// Faça um programa que leia as variáveis C e N, respectivamente código e número de horas trabalhadas de um operário.
// Calcule o salário sabendo-se que ele ganha R$ 10,00 por hora.
// Quando o número de horas exceder a 50, calcule o excesso de pagamento armazenando-o na variável E, caso contrário zerar
// tal variável.
// A hora excedente de trabalho vale R$ 20,00.
// No final do processamento imprimir o salário total e o salário excedente.
// O programa só deve parar de rodar quando o usuário responder "S" na seguinte pergunta, "Deseja encerrar o programa?".

namespace ExerciciosCSharp.Exercicios {

    internal class Exercicio38 {

        public static void Executar() {
            //  variáveis
            double E, salarioTotal, salarioExcedente;

            // Variável terminar o programa
            char parar = 'n';

            // Laço para executar o programa enquanto o usuário desejar
            while (parar == 'n' || parar == 'N') {
                // Solicitando ao usuário o Código do operário e as horas trabalhadas.
                Console.Write("Informe o código do operário: ");
                _ = double.TryParse(Console.ReadLine(), out double C);
                Console.Write("Informe as horas trabalhadas: ");
                _ = double.TryParse(Console.ReadLine(), out double N);

                // Teste para verificar se foram trabalhado horas acima de 50 e faz os calculos necessários.
                if (N > 50) {
                    E = N - 50;
                    N -= E;
                    E *= 20;
                    N *= 10;
                } else {
                    E = 0;
                    N *= 10;
                }

                // Colocando os valores nas variáveis que serão imprimidas.
                salarioTotal = N + E;
                salarioExcedente = E;

                // Imprimindo os salários
                Console.WriteLine($"\nO sálario total do operário {C} é: {salarioTotal:F2}");
                Console.WriteLine($"O salário excedente do operário {C} é: {salarioExcedente:F2}");

                // Pergunta se o usuário deseja encerrar o programa
                Console.Write("\nDeseja encerrar o programa?(S/N): ");
                _ = char.TryParse(Console.ReadLine(), out parar);
                Console.WriteLine("");
            }
        }
    }
}
