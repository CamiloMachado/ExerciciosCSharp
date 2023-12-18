// Escreva um programa que deverá ter as seguintes opções:

// 1 - Carregar Vetor
// 2 - Listar Vetor
// 3 - Exibir apenas os números pares do vetor
// 4 - Exibir apenas os números ímpares do vetor
// 5 - Exibir a quantidade de números pares existem nas posições ímpares do vetor
// 6 - Exibir a quantidade de números ímpares existem nas posições pares do vetor
// 7 - Sair

//Deverá ser implementado um método para realizar cada uma das opções de 1 a 6.

namespace ExerciciosCSharp.Exercicios {

    internal class Exercicio64 {

        private static void CarregarVetor(double[] vetor) {
            // Laço para o usuário fazer a carga dos dados no vetor.
            for (int i = 0; i < vetor.Length; i++) {
                Console.Write("Informe o valor que será guardado na {0}º do vetor: ", i + 1);
                _ = double.TryParse(Console.ReadLine(), out vetor[i]);
            }
            Console.WriteLine("");
        }

        private static void ListarVetor(double[] vetor) {
            Console.WriteLine("Listando os valores guardado no vetor!");
            // Faz uma validação se foi carregado o vetor antes de listar ele.
            // Feito uma tratativa de erro caso o vetor não estaja carregado.
            if (vetor[0] != 0000) {
                for (int i = 0; i < vetor.Length; i++) {
                    Console.WriteLine("O valor guardado na {0}º do vetor é: {1}", i + 1, vetor[i]);
                }
            } else {
                Console.WriteLine("O vetor ainda não foi carregado!");
                Console.WriteLine("Favor carregar o vetor!");
            }
            Console.WriteLine("");
        }

        private static void ExibirPares(double[] vetor) {
            Console.Write("Exibindo os Valores pares: ");
            // Faz uma validação se foi carregado o vetor antes de exibir os números pares.
            // Feito uma tratativa de erro caso o vetor não estaja carregado.
            if (vetor[0] != 0000) {
                foreach (double v in vetor) {
                    if (v % 2 == 0) {
                        Console.Write("{0} ", v);
                    }
                }
                Console.WriteLine("\n");
            } else {
                Console.WriteLine("O vetor ainda não foi carregado!");
                Console.WriteLine("Favor carregar o vetor!");
                Console.WriteLine("");
            }
        }

        private static void ExibirImpares(double[] vetor) {
            Console.Write("Exibindo os Valores ímpares: ");
            // Faz uma validação se foi carregado o vetor antes de exibir os números ímpares.
            // Feito uma tratativa de erro caso o vetor não estaja carregado.
            if (vetor[0] != 0000) {
                foreach (double v in vetor) {
                    if (v % 2 != 0) {
                        Console.Write("{0} ", v);
                    }
                }
                Console.WriteLine("\n");
            } else {
                Console.WriteLine("O vetor ainda não foi carregado!");
                Console.WriteLine("Favor carregar o vetor!");
                Console.WriteLine("");
            }
        }

        private static void QuantidadeParesPosicoesImpares(double[] vetor) {
            // Variável que vai guardar o valor total de número pares em posições ímpares.
            uint paresPosicoesImpares = 0;
            // Faz uma validação se foi carregado o vetor antes de exibir a quantidade de números pares em posições ímpares.
            // Feito uma tratativa de erro caso o vetor não estaja carregado.
            if (vetor[0] != 0000) {
                for (int i = 0; i < vetor.Length; i++) {
                    if (vetor[i] % 2 == 0 && (i + 1) % 2 != 0) {
                        paresPosicoesImpares++;
                    }
                }
                Console.WriteLine("O total de números pares em posições ímpares é: {0}", paresPosicoesImpares);
            } else {
                Console.WriteLine("O vetor ainda não foi carregado!");
                Console.WriteLine("Favor carregar o vetor!");
            }
            Console.WriteLine("");
        }

        private static void QuantidadeImparesPosicoesPares(double[] vetor) {
            // Variável que vai guardar o valor total de número ímpares em posições pares.
            uint imparesPosicoesPares = 0;
            // Faz uma validação se foi carregado o vetor antes de exibir a quantidade de números ímpares em posições pares.
            // Feito uma tratativa de erro caso o vetor não estaja carregado.
            if (vetor[0] != 0000) {
                for (int i = 0; i < vetor.Length; i++) {
                    if (vetor[i] % 2 != 0 && (i + 1) % 2 == 0) {
                        imparesPosicoesPares++;
                    }
                }
                Console.WriteLine("O total de números ímpares em posições pares é: {0}", imparesPosicoesPares);
            } else {
                Console.WriteLine("O vetor ainda não foi carregado!");
                Console.WriteLine("Favor carregar o vetor!");
            }
            Console.WriteLine("");
        }

        public static void Executar() {
            // Variável onde guarda a opção escolhida pelo usuário.
            uint opcao = 0;
            Console.WriteLine("Bem vindo!");

            // Solicita ao usuário o tamanho desejado do vetor.
            Console.Write("Informe quantos valores serão colocados no vetor: ");
            _ = int.TryParse(Console.ReadLine(), out int tamanhoVetor);
            Console.WriteLine("");

            // Cricação do vetor
            double[] vetor = new double[tamanhoVetor];

            // Usado para validação se o vetor foi carragado antes de efetuar as apções onde necessita dele carregado.
            vetor[0] = 0000;

            // Laço infinito que termina com a opção 7.
            while (opcao != 7) {
                // Mostra as opções ao usuário e guarda a opão na variável opcao.
                Console.WriteLine("Opções:");
                Console.WriteLine("");
                Console.WriteLine("1 - Carregar Vetor;");
                Console.WriteLine("2 - Listar Vetor;");
                Console.WriteLine("3 - Exibir apenas os números pares do vetor;");
                Console.WriteLine("4 - Exibir apenas os números ímpares do vetor;");
                Console.WriteLine("5 - Exibir a quantidade de números pares existem nas posições ímpares do vetor;");
                Console.WriteLine("6 - Exibir a quantidade de números ímpares existem nas posições pares do vetor;");
                Console.WriteLine("7 - Sair;");
                Console.WriteLine("");
                Console.Write("Informe a opção desejada: ");
                _ = uint.TryParse(Console.ReadLine(), out opcao);

                Console.WriteLine("");

                // Usado o switch por ser mais prático e legível, mas pode ser usado também uma cadeia de if/else if.
                // Vai para opção desejada e chama o método ou termina o laço.
                switch (opcao) {
                    case 1:
                        CarregarVetor(vetor);
                        break;

                    case 2:
                        ListarVetor(vetor);
                        break;

                    case 3:
                        ExibirPares(vetor);
                        break;

                    case 4:
                        ExibirImpares(vetor);
                        break;

                    case 5:
                        QuantidadeParesPosicoesImpares(vetor);
                        break;

                    case 6:
                        QuantidadeImparesPosicoesPares(vetor);
                        break;

                    case 7:
                        Console.WriteLine("Fim!");
                        break;

                    default:
                        Console.WriteLine("Opação inválida!");
                        break;
                }
            }
        }
    }
}
