using System;

class Program
{
    static string CaracteresImpares(string entrada)
    {
        string resultado = "";

        for (int i = 1; i < entrada.Length; i += 2) // Começa no índice 1 e avança de 2 em 2
        {
            resultado += entrada[i]; // Adiciona apenas caracteres em índices ímpares
        }

        return resultado;
    }

    static void Main(string[] args)
    {
        Console.Write("Digite uma palavra ou frase: ");
        string texto = Console.ReadLine();

        string resultado = CaracteresImpares(texto);

        Console.WriteLine("Caracteres em posições ímpares: " + resultado);
        
        Console.WriteLine("Pressione qualquer tecla para sair . . .");
        Console.ReadKey(true);
    }
}
