using System;
using System.Linq;
using static System.Console;

namespace Ex10
{
    class Program
    {
        static void Main()
        {
            string response;
            
            do
            {
                Console.WriteLine("Informar uma palavra, frase ou sequência numérica. Verificaremos se é um palindromo.");
                string text;
                text = Console.ReadLine().ToLower();
                WriteLine($"Texto Normal: {text}");
                string reverseText = new string(text.Reverse().ToArray());
                WriteLine($"Texto Invertido: {reverseText}");
                WriteLine("Pressione Enter para verificar o resultado!");
                ReadLine();
                if (text == reverseText)
                {
                    Console.WriteLine("O argumento de entrada é um palindromo");
                }
                else
                {
                    Console.WriteLine("O argumento de entrada não é um palindromo.");
                }
                Console.WriteLine("Gostaria de passa um novo argumento? (s/n)");
                response = Console.ReadLine();
            } while (response.ToLower() == "s");
            
            Console.WriteLine("Programa encerrado. Pressione Enter para sair.");
            Console.ReadLine();
        }
    }
}