using ExerciciosCSharp.Exercicios;

namespace ExerciciosCSharp {

    internal class Program {

        private static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Exercícios
                // Nível 1: Entrada, Processamento e Saída
                {"Exercicio #01", Exercicio1.Executar},
                {"Exercicio #02", Exercicio2.Executar},
                {"Exercicio #03", Exercicio3.Executar},
                {"Exercicio #04", Exercicio4.Executar},
                {"Exercicio #05", Exercicio5.Executar},
                {"Exercicio #06", Exercicio6.Executar},
                {"Exercicio #07", Exercicio7.Executar},
                {"Exercicio #08", Exercicio8.Executar},
                {"Exercicio #09", Exercicio9.Executar},
                {"Exercicio #10", Exercicio10.Executar},

                //Nível 2: Estruturas Condicionais
                {"Exercicio #11", Exercicio11.Executar},
                {"Exercicio #12", Exercicio12.Executar},
                {"Exercicio #13", Exercicio13.Executar},
                {"Exercicio #14", Exercicio14.Executar},
                {"Exercicio #15", Exercicio15.Executar},
                {"Exercicio #16", Exercicio16.Executar},
                {"Exercicio #17", Exercicio17.Executar},
                {"Exercicio #18", Exercicio18.Executar},
                {"Exercicio #19", Exercicio19.Executar},
                {"Exercicio #20", Exercicio20.Executar},
                {"Exercicio #21", Exercicio21.Executar},
                {"Exercicio #22", Exercicio22.Executar},

                // Nível 3: Estrutura de Seleção
                {"Exercicio #23", Exercicio23.Executar},
                {"Exercicio #24", Exercicio24.Executar},
                {"Exercicio #25", Exercicio25.Executar},

                // Nível 4: Estruturas de Repetição
                {"Exercicio #26", Exercicio26.Executar},
                {"Exercicio #27", Exercicio27.Executar},
                {"Exercicio #28", Exercicio28.Executar},
                {"Exercicio #29", Exercicio29.Executar},
                {"Exercicio #30", Exercicio30.Executar},
                {"Exercicio #31", Exercicio31.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}
