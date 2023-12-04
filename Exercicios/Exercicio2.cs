using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCSharp.Exercicios {

    // Faça um programa que: 
    // - Leia a cotação do dólar 
    // - Leia um valor em dólares 
    // - Converta esse valor para Real 
    // - Mostre o resultado

    internal class Exercicio2 {

        public static void Executar() {

            // Criação das variáveis
            double cotacaoDolar = 4.92;
            double valorDolar = 300;
            double valorEmReal = 0;

            // Calculo da valor em real
            valorEmReal = cotacaoDolar * valorDolar;

            // Mostrar os valores
            Console.WriteLine($"Cotação do dólar: {cotacaoDolar}");
            Console.WriteLine($"Valor em dólares: {valorDolar}");
            Console.WriteLine($"Valor em reais: {valorEmReal}");
        }
    }
}
