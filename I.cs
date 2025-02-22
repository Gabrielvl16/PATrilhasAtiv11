using System;

class Program
{
    static bool VerificarPrimo(int numero)
    {
        if (numero <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    static void Main(string[] args)
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        if (VerificarPrimo(numero))
        {
            Console.WriteLine("O número " + numero + " é primo.");
        }
        else
        {
            Console.WriteLine("O número " + numero + " não é primo.");
        }
    }
}
