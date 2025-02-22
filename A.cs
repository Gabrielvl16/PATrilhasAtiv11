using System;

namespace Lista_metodos
{
    class Program
    {
        static int Quadrado(int numero)
        {
            return numero * numero;
        }

        static void Main()
        {
            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("O seu número ao quadrado é: " + Quadrado(numero));

            Console.WriteLine("Pressione qualquer tecla para sair . . .");
            Console.ReadKey(true);
        }
    }
}

