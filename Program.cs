using System;

namespace cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite uma frase:");
            string frase;
            frase = Console.ReadLine();

            Console.WriteLine("Cebolinha Diz:");

            string Cebolinha;
            Cebolinha = frase.Replace("r", "l").Replace("R","L");
            Console.WriteLine(Cebolinha);
            

           
        }
    }
}
