using System;

class Program
{
    static int EncontrarMaiorNumero(int[] numeros)
    {
        int maiorNumero = numeros[0];
        
        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] > maiorNumero)
            {
                maiorNumero = numeros[i];
            }
        }

        return maiorNumero;
    }

    static void Main(string[] args)
    {
        int[] numeros = { 10, 25, 3, 18, 55, 42 };
        
        int maiorNumero = EncontrarMaiorNumero(numeros);
        Console.WriteLine("O maior número do array é: " + maiorNumero);
    }
}
