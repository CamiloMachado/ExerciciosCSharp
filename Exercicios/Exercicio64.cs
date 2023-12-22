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

        private int TamanhoVetor() {
            // Solicita ao usuário o tamanho desejado do vetor.
            Console.Write("\nInforme quantos valores serão colocados no vetor: ");
            _ = int.TryParse(Console.ReadLine(), out int tamanhoVetor);

            return tamanhoVetor;
        }

        private bool ValidaTamanhoVetor(int tamanhoVetor) {
            // Valida se o tamanho do vetor está com um valor válido.
            if (tamanhoVetor <= 0) {
                return true;
            }
            return false;
        }

        private bool RepetirTamanhoVetor() {
            Console.Write("\nDeseja informar o tamanho do vetor novamente(S/N): ");
            _ = char.TryParse(Console.ReadLine(), out char repetirTamanhoVetor);

            // Válida se o que foi informado pelo usuário,
            // será para repetir ou não, o processo onde é informado o tamanho do vetor.
            if (repetirTamanhoVetor == 's' || repetirTamanhoVetor == 'S') {
                return true;
            }
            return false;
        }

        private double[] CriarVetor(int tamanhoVetor) {
            // Cria o vetor, com o tamanho informado.
            double[] vetor = new double[tamanhoVetor];
            return vetor;
        }

        private bool ValidaOpcao(uint opcao) {
            // Se a opção informada está no range entre 1 e 7.
            if (opcao >= 1 && opcao < 7) {
                return true;
            }
            return false;
        }

        private uint MenuPrincipal() {
            Console.WriteLine("");
            // Mostra as opções ao usuário e guarda a opção na variável opcao.
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
            _ = uint.TryParse(Console.ReadLine(), out uint opcao);

            Console.WriteLine("");

            return opcao;
        }

        private bool ValidaVetor(double[] vetor) {
            // laço onde válida se o vetor está com valor válido, diferente de 0.
            // Se for igual a 0, guarda na variável numVetorInvalido.
            // Será informado ao usuário que o valor na posição é inválido.
            int numVetorInvalido = 0;
            for (int i = 0; i < vetor.Length; i++) {
                if (vetor[i] == 0) {
                    numVetorInvalido++;
                    Console.WriteLine("O número na posição {0} é inválido!", i + 1);
                }
            }

            Console.WriteLine("");

            // Se a variável tiver um valor maior que 0, será informado ao usuário que houve problema na carga do vetor.
            if (numVetorInvalido > 0) {
                return true;
            }
            return false;
        }

        private void MenuOpcoes(uint opcao, double[] vetor) {
            // Efetuado a instância da classe para que os métodos não estáticos sejam acessado pelo método estático.
            Exercicio64 programa = new();

            // Usado o switch por ser mais prático e legível, mas pode ser usado também uma cadeia de if/else if.
            // Chama o método desejado.
            switch (opcao) {
                case 1:
                    programa.CarregarVetor(vetor);
                    break;

                case 2:
                    programa.ListarVetor(vetor);
                    break;

                case 3:
                    programa.ExibirPares(vetor);
                    break;

                case 4:

                    programa.ExibirImpares(vetor);
                    break;

                case 5:

                    programa.QuantidadeParesPosicoesImpares(vetor);
                    break;

                case 6:

                    programa.QuantidadeImparesPosicoesPares(vetor);
                    break;

                case 7:
                    Console.WriteLine("Fim!");
                    break;
            }
        }

        private void CarregarVetor(double[] vetor) {
            // Laço para o usuário fazer a carga dos dados no vetor.
            for (int i = 0; i < vetor.Length; i++) {
                Console.Write("Informe o valor que será guardado na {0}º do vetor: ", i + 1);
                _ = double.TryParse(Console.ReadLine(), out vetor[i]);
            }
        }

        private void ListarVetor(double[] vetor) {
            Console.WriteLine("Listando os valores guardados no vetor!");
            Console.WriteLine("");

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

            // Criação do vetor e uma variável para validar se o tamanho do vetor está maior do que 0.
            double[] vetor;
            bool validaTamanhoVetor = true;

            Console.WriteLine("Bem vindo!");

            //Variável que recebe do método o valor do tamanho do vetor.
            int tamanhoVetor = programa.TamanhoVetor();

            // Valida  se o tamanho do vetor informado é maior do que 0.
            // Se não imprimi uma mensagem de erro e válida se o usuário deseja informar novo tamanha para o vetor.
            while (validaTamanhoVetor) {
                try {
                    if (programa.ValidaTamanhoVetor(tamanhoVetor)) {
                        throw new ArgumentException("\nO tamanho do vetor não pode ser menor igual a 0!");
                    } else {
                        validaTamanhoVetor = false;
                    }
                } catch (ArgumentException error) {
                    Console.WriteLine(error.Message);
                    if (programa.RepetirTamanhoVetor()) {
                        tamanhoVetor = programa.TamanhoVetor();
                    } else {
                        validaTamanhoVetor = false;
                    }
                }
            }

            // Valida se o tamanho está correto cotinua a execução do programa,
            // se o usuário não informou correto e não quis repetir o tamanho saí do programa.
            if (!programa.ValidaTamanhoVetor(tamanhoVetor)) {
                // Cricação do vetor
                vetor = programa.CriarVetor(tamanhoVetor);

                // Laço usado para guardar um valor em todas as posições,
                // para validar se o vetor foi carragado corretamente,
                // antes de efetuar as opções onde necessita dele carregado.
                for (int i = 0; i < vetor.Length; i++) {
                    vetor[i] = 0;
                }

                // Criação da variável opcaoEscolhida e guardar o retorno do método.
                uint opcaoEscolhida = programa.MenuPrincipal();

                // Laço que valida se foi esolhido uma opção válida.
                // Se for inválida informa ao usuário.
                // Se for 7 termina o programa.
                while (opcaoEscolhida != 7) {
                    if (programa.ValidaOpcao(opcaoEscolhida)) {
                        if (opcaoEscolhida == 1) {
                            programa.MenuOpcoes(opcaoEscolhida, vetor);
                        } else if (programa.ValidaVetor(vetor)) { // Válida o vetor se está válido ou não.
                            Console.WriteLine("O vetor não foi carregado corretamente!" +
                            "\nFavor, efetuar cargar no vetor!");
                        } else {
                            programa.MenuOpcoes(opcaoEscolhida, vetor);
                        }
                        opcaoEscolhida = programa.MenuPrincipal();
                    } else {
                        Console.WriteLine("A opção escolhida é inválida!");
                        opcaoEscolhida = programa.MenuPrincipal();
                    }
                }
            } else {
                Console.WriteLine("\nFim!"); // Aqui o tamanho do vetor e o usuário não quis informar o tamanho do vetor.
            }
        }
    }
}
