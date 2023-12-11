//Faça um programa que dada a idade de um nadador, classifique-o em uma das seguintes categorias:
// - Infantil A = 5 a 7 anos
// - Infantil B = 8 a 11 anos
// - Juvenil A = 12 a 13 anos
// - Juvenil B = 14 a 17 anos
// - Adultos = Maiores de 18 anos

namespace ExerciciosCSharp.Exercicios {

    internal class Exercicio41 {

        public static void Executar() {
            Console.Write("Informe a idade do nadador: ");
            _ = uint.TryParse(Console.ReadLine(), out uint idade);

            Console.WriteLine("");
            //
            if (idade >= 18) {
                Console.WriteLine("Categoria Adulto!");
            } else if (idade >= 14 && idade <= 17) {
                Console.WriteLine("Categoria Juvenil B");
            } else if (idade >= 12 && idade <= 13) {
                Console.WriteLine("Categoria Juvenil A");
            } else if (idade >= 8 && idade <= 11) {
                Console.WriteLine("Categoria Infantil B");
            } else if (idade >= 5 && idade <= 7) {
                Console.WriteLine("Categoria Infantil A");
            } else {
                Console.WriteLine("Não tem idade suficiente!");
            }
        }
    }
}
