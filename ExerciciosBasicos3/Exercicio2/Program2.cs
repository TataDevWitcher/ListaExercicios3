using System;
using System.Runtime.ConstrainedExecution;
using System.Xml;

namespace Exercicio2
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*Leitura de coordenadas inteiras*");
            Console.WriteLine("Obs.: Programa encerra se uma das duas coordenadas for igual à 0");

            int coordenadax, coordenaday;

            Console.WriteLine("Insira as coordenadas X e Y respectivamente separadas apenas por um espaço. Ex.:2 2:");
            string [] coordenadas = Console.ReadLine().Split(' ');
            coordenadax = int.Parse(coordenadas[0]);
            coordenaday = int.Parse(coordenadas[1]);

            while (coordenaday != 0 && coordenadax != 0)
            {
                if (coordenadax > 0 && coordenaday > 0)
                {
                    Console.WriteLine("Coordenadas estão no 1º quadrante!");
                }
                else if (coordenadax < 0 && coordenaday > 0)
                {
                    Console.WriteLine("Coordenadas estão no 2º quadrante!");
                }
                else if (coordenadax < 0 && coordenaday < 0)
                {
                    Console.WriteLine("Coordenadas estão no 3º quadrante!");
                }
                else 
                {
                    Console.WriteLine("Coordenadas estão no 4º quadrante!");
                }

                Console.WriteLine("");
                Console.WriteLine("Insira as coordenadas X e Y respectivamente separadas apenas por um espaço.");
                coordenadas = Console.ReadLine().Split(' ');
                coordenadax = int.Parse(coordenadas[0]);
                coordenaday = int.Parse(coordenadas[1]);
            }

            Console.WriteLine("Programa encerrado por inserção de coordenada igual à 0.");
        }
    }
}