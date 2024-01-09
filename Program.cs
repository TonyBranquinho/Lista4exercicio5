using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite um numero.");
            int n = int.Parse(Console.ReadLine());

            int fatorial = 1;
            for (int i = 1; i <= n; i++) {
                fatorial = fatorial *  i;
            }

            Console.WriteLine(fatorial);
        }
    }
}