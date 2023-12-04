using System;

namespace ExerciciosCSharp.Exercicios {

    // Faça um programa para pagamento de comissão de vendedores de peças, levando-se em consideração que sua 
    // comissão será de 5% do total da venda e que você tem os seguintes dados: 
    // - Identificação do vendedor 
    // - Código da peça 
    // - Preço unitário da peça
    // - Quantidade vendida

    internal class Exercicio3 {

        public static void Executar() {

            // Criação das variáveis
            string nomeDoVendendor = "Camilo";
            int codigoDaPeca = 7;
            double precoDaPeca = 1985.09;
            int quantidaVendida = 38;

            // Calculo do valor total
            double totalVenda = quantidaVendida * precoDaPeca;

            // Calculo da comissão do vendedor
            double comissao = totalVenda * 0.05;

            // Mostrando os resultados
            Console.WriteLine("O vendedor {0}, efetuou a venda de {1} peças do código {2}.", nomeDoVendendor, quantidaVendida, codigoDaPeca);
            Console.WriteLine($"O valor total da venda: {totalVenda}");
            Console.WriteLine($"O valor da comissão pela venda é de: {comissao.ToString("F")}");

        }
    }
}
