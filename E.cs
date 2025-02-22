using System;

class Program
{
    static string Palavras(string[] palavraUsuario)
    {
        string resultado = ""; 

        for (int i = 0; i < palavraUsuario.Length; i++)
        {
            resultado += palavraUsuario[i] + " "; 
        }

        return resultado.Trim(); 
    }

    static void Main(string[] args)
    { 
        Console.WriteLine("Digite palavras separadas por espaço:");
        string palavraUsuario = Console.ReadLine();
        
        string resultadoConcatenado = Palavras(palavraUsuario.Split(' '));
        
        Console.WriteLine("Palavras concatenadas: " + resultadoConcatenado);

        Console.Write("Pressione qualquer tecla para sair . . .");
        Console.ReadKey(true);
    }
}
