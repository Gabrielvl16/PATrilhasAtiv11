using System;

namespace Lista_11
{
    class Program
    {
        static int NumeroCaracteres(string texto)
        {
            return texto.Length;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma palavra: ");
            string palavra = Console.ReadLine();
            Console.WriteLine("A quantidade de letras na sua palavra é: " + NumeroCaracteres(palavra));
            
            Console.WriteLine("Pressione qualquer tecla para finalizar . . .");
            Console.ReadKey();
        }
    }
}
