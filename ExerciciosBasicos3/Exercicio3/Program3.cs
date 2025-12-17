using System;

namespace Exercicio3
{
    class Program3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*Pesquisa de satisfação - Posto Lorem Ipsum*");
            Console.WriteLine("------------------------------");
            Console.WriteLine("|  Código       Combustível  |");
            Console.WriteLine("|    1            Álcool     |");
            Console.WriteLine("|    2            Gasolina   |");
            Console.WriteLine("|    3            Diesel     |");
            Console.WriteLine("|    4            Fim        |");
            Console.WriteLine("------------------------------");

            Console.WriteLine("Digite o código correspondente do combustível que você abastece:");

            int combustivel = int.Parse(Console.ReadLine());

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            while (combustivel != 4)
            {
                if (combustivel == 1)
                {
                    alcool++;
                }
                else if (combustivel == 2)
                {
                    gasolina++;
                }
                else if (combustivel == 3)
                {
                    diesel++;
                }
                else
                {
                    Console.WriteLine("Código inválido. Por favor, insira um código válido (1 a 4):");
                }
                Console.WriteLine("");
                Console.WriteLine("Digite o código correspondente do combustível que você abastece:");
                combustivel = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("");
            Console.WriteLine("Fim do programa. Muito obrigada!");
            Console.WriteLine($"Álcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");
        }
    }
}