using System;
using System.Globalization;

namespace Exercicio1
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*Validador de senha correta*");
            Console.WriteLine("Tente descobrir a senha secreta. Dica: Já passamos por esse ano, entre 1990 e 2025.");
            Console.WriteLine("Insira a senha: ");

            int senhaSecreta = int.Parse(Console.ReadLine());

            while (senhaSecreta != 2002)
            {
                Console.WriteLine("A senha é inválida");
                senhaSecreta = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso permitido!");
            Console.WriteLine("CARREGANDO...");

        }
    }
}
