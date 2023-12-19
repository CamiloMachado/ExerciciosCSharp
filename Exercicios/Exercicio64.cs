﻿// Escreva um programa que deverá ter as seguintes opções:

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

        private void CarregarVetor(double[] vetor) {
            // Laço para o usuário fazer a carga dos dados no vetor.
            for (int i = 0; i < vetor.Length; i++) {
                Console.Write("Informe o valor que será guardado na {0}º do vetor: ", i + 1);
                _ = double.TryParse(Console.ReadLine(), out vetor[i]);
            }
        }

        private void ListarVetor(double[] vetor) {
            Console.WriteLine("Listando os valores guardado no vetor!");

            // laço para listar o vetor.
            for (int i = 0; i < vetor.Length; i++) {
                Console.WriteLine("O valor guardado na {0}º do vetor é: {1}", i + 1, vetor[i]);
            }
        }

        private void ExibirPares(double[] vetor) {
            Console.Write("Exibindo os Valores pares: ");

            // Laço com uma validação, antes de exibir os números pares.
            foreach (double v in vetor) {
                if (v % 2 == 0) {
                    Console.Write("{0} ", v);
                }
            }
            Console.WriteLine("");
        }

        private void ExibirImpares(double[] vetor) {
            Console.Write("Exibindo os Valores ímpares: ");

            // Laço com uma validação, antes de exibir os números ímpares.
            foreach (double v in vetor) {
                if (v % 2 != 0) {
                    Console.Write("{0} ", v);
                }
            }
            Console.WriteLine("");
        }

        private void QuantidadeParesPosicoesImpares(double[] vetor) {
            // Variável que vai guardar o valor total de número pares em posições ímpares.
            uint paresPosicoesImpares = 0;

            // Laço com uma validação, antes de exibir a quantidade de números pares em posições ímpares.
            for (int i = 0; i < vetor.Length; i++) {
                if (vetor[i] % 2 == 0 && (i + 1) % 2 != 0) {
                    paresPosicoesImpares++;
                }
            }
            Console.WriteLine("O total de números pares em posições ímpares é: {0}", paresPosicoesImpares);
        }

        private void QuantidadeImparesPosicoesPares(double[] vetor) {
            // Variável que vai guardar o valor total de número ímpares em posições pares.
            uint imparesPosicoesPares = 0;

            // Laço com uma validação, antes de exibir a quantidade de números ímpares em posições pares.
            for (int i = 0; i < vetor.Length; i++) {
                if (vetor[i] % 2 != 0 && (i + 1) % 2 == 0) {
                    imparesPosicoesPares++;
                }
            }
            Console.WriteLine("O total de números ímpares em posições pares é: {0}", imparesPosicoesPares);
        }

        public static void Executar() {
            // Efetuado a instância da classe para que os métodos não estáticos sejam acessado pelo método estático.
            Exercicio64 programa = new();

            // Variável onde guarda a opção escolhida pelo usuário.
            uint opcao = 0;
            Console.WriteLine("Bem vindo!");

            // Solicita ao usuário o tamanho desejado do vetor.
            Console.Write("Informe quantos valores serão colocados no vetor: ");
            _ = int.TryParse(Console.ReadLine(), out int tamanhoVetor);

            // Cricação do vetor
            double[] vetor = new double[tamanhoVetor];

            // Usado para validação se o vetor foi carragado antes de efetuar as apções onde necessita dele carregado.
            vetor[0] = 0000;

            // Laço infinito que termina com a opção 7.
            while (opcao != 7) {
                Console.WriteLine("");
                // Mostra as opções ao usuário e guarda a opão na variável opcao.
                Console.WriteLine("Opções:");
                Console.WriteLine("");
                Console.WriteLine("1 - Carregar Vetor;");
                Console.WriteLine("2 - Listar Vetor;");
                Console.WriteLine("3 - Exibir apenas os números pares do vetor,");
                Console.WriteLine("4 - Exibir apenas os números ímpares do vetor,");
                Console.WriteLine("5 - Exibir a quantidade de números pares existem nas posições ímpares do vetor,");
                Console.WriteLine("6 - Exibir a quantidade de números ímpares existem nas posições pares do vetor,");
                Console.WriteLine("7 - Sair.");
                Console.WriteLine("");
                Console.Write("Informe a opção desejada: ");
                _ = uint.TryParse(Console.ReadLine(), out opcao);

                Console.WriteLine("");

                // Usado o switch por ser mais prático e legível, mas pode ser usado também uma cadeia de if/else if.
                // Vai para opção desejada e chama o método ou termina o laço.
                try {
                    switch (opcao) {
                        case 1:
                            programa.CarregarVetor(vetor);
                            break;

                        case 2:
                            // Faz uma validação se foi carregado o vetor.
                            // Feito uma tratativa de erro caso o vetor não estaja carregado.
                            if (vetor[0] != 0000) {
                                programa.ListarVetor(vetor);
                            } else {
                                throw new ArgumentException("O vetor ainda não foi carregado!" +
                                    "\nFavor carregar o vetor!");
                            }
                            break;

                        case 3:
                            // Faz uma validação se foi carregado o vetor antes de exibir os números pares.
                            // Feito uma tratativa de erro caso o vetor não estaja carregado.
                            if (vetor[0] != 0000) {
                                programa.ExibirPares(vetor);
                            } else {
                                throw new ArgumentException("O vetor ainda não foi carregado!" +
                                    "\nFavor carregar o vetor!");
                            }
                            break;

                        case 4:
                            // Faz uma validação se foi carregado o vetor.
                            // Feito uma tratativa de erro caso o vetor não estaja carregado.
                            if (vetor[0] != 0000) {
                                programa.ExibirImpares(vetor);
                            } else {
                                throw new ArgumentException("O vetor ainda não foi carregado!" +
                                    "\nFavor carregar o vetor!");
                            }
                            break;

                        case 5:
                            // Faz uma validação se foi carregado o vetor.
                            // Feito uma tratativa de erro caso o vetor não estaja carregado.
                            if (vetor[0] != 0000) {
                                programa.QuantidadeParesPosicoesImpares(vetor);
                            } else {
                                throw new ArgumentException("O vetor ainda não foi carregado!" +
                                    "\nFavor carregar o vetor!");
                            }
                            break;

                        case 6:
                            // Faz uma validação se foi carregado o vetor.
                            // Feito uma tratativa de erro caso o vetor não estaja carregado.
                            if (vetor[0] != 0000) {
                                programa.QuantidadeImparesPosicoesPares(vetor);
                            } else {
                                throw new ArgumentException("O vetor ainda não foi carregado!" +
                                    "\nFavor carregar o vetor!");
                            }
                            break;

                        case 7:
                            Console.WriteLine("Fim!");
                            break;

                        default:
                            throw new ArgumentException("Opção inválida!");
                    }
                } catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
