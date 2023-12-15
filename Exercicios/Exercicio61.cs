// Escreva um programa que calcule e retorne o salário atualizado através do método REAJUSTE.
// O método deve receber o valor do salário e o índice de reajuste.

namespace ExerciciosCSharp.Exercicios {
    //internal class Reajuste() {
    //    internal double Salario;
    //    internal double IndiceReajuste;

    //    public double Atualizar() {
    //        return this.Salario + (this.Salario / 100 * this.IndiceReajuste);
    //    }
    //}

    internal class Exercicio61 {

        public static double Reajuste(double salario, double indiceReajuste) {
            return salario + (salario / 100 * indiceReajuste);
        }

        public static void Executar() {
            // Solicitado ao usuário o sálario
            Console.Write("Informe o sálario: ");
            _ = double.TryParse(Console.ReadLine(), out double salario);

            Console.WriteLine("");

            // Solicitado ao usuário o indide reajuste
            Console.Write("Informe o índice de reajuste: ");
            _ = double.TryParse(Console.ReadLine(), out double indiceReajuste);

            Console.WriteLine("");

            double salarioAtualizado = Reajuste(salario, indiceReajuste);

            // Variável onde será quardado o calculo feito no método
            //Reajuste salarioAtualizado = new() {
            //    Salario = salario,
            //    IndiceReajuste = indiceReajuste
            //};

            // Imprime o valor do salário atualizado.
            //Console.WriteLine($"O sálario atualizado é: {salarioAtualizado.Atualizar():F2}");
            Console.WriteLine($"O sálario atualizado é: {salarioAtualizado:F2}");
        }
    }
}
