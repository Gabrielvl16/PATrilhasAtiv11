using System;

class Program
{
    static double calcularMedia(int quantidade, int soma)
    {
        if (quantidade == 0) return 0; // Evita divisão por zero
        return (double)soma / quantidade;
    }

    static void Main(string[] args)
    {
        int numero, contador = 0, soma = 0;

        Console.WriteLine("Digite vários números (Digite 0 para sair):");

        do
        {
            Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                soma += numero; // Soma os números válidos
                contador++; // Conta os números digitados
            }
            else
            {
                break;
            }
        } while (true);

        double media = calcularMedia(contador, soma); // Calcula a média

        if (contador > 0)
        {
            Console.WriteLine("A média dos números é: " + media);
        }
        else
        {
            Console.WriteLine("Nenhum número válido foi digitado.");
        }
    }
}
