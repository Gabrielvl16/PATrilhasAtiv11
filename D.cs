using System;

class Program
{ 
    // Criando metodo da soma
    static int Soma(int a, int b)
    {
        return a + b;
    }
    
    static void Main(string[] args)
    { 
        // Recebendo valor do usuário
       Console.WriteLine("Digite dois números para serem somados: ");
       Console.WriteLine("Primeiro número:");
       int numero1 = int.Parse(Console.ReadLine()); 
       
       Console.WriteLine("Segundo número: ");
       int numero2 = int.Parse(Console.ReadLine());
       
       // Exibindo resultado 
       Console.WriteLine("O resultado da soma dos números é: " + Soma(numero1, numero2));
       
       Console.Write("Pressione qualquer tecla para sair . . .");
       Console.ReadKey(true);
    }
}
