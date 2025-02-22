using System;

class Program
{
    static int ImparPar(int x)
    {
        if (x % 2 == 0)
        {
            return 0;
        }
        else
        {
            return 1;
        }
        
    }
    
    static void Main(string[] args)
    { 
      Console.WriteLine("Digite um número: ");
      int numero = int.Parse(Console.ReadLine());
      
      if (ImparPar(numero) == 0)
      {
          Console.WriteLine("Seu número é par.");
      } 
      else
      {
          Console.WriteLine("Seu número é impar.");
      }
      Console.WriteLine("Pressione qualquer tecla para sair . . .");
      Console.ReadKey(true)
    }
}
