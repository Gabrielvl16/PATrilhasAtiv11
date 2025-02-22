using System;

class Program
{
    static int EncontrarMenorNumero(int[] numeros)
    {
        int menor = numeros[0];

        foreach (int numero in numeros)
        {
            if (numero < menor)
            {
                menor = numero;
            }
        }

        return menor;
    }

    static void Main(string[] args)
    {
        int[] numeros = { 15, 3, 8, 22, 5 };

        int menorNumero = EncontrarMenorNumero(numeros);

        Console.WriteLine("O menor número do array é: " + menorNumero);
    }
}
