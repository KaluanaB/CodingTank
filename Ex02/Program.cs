using System;

namespace ex2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Fala comigo! Qual Seu nome?");
            string name = Console.ReadLine();
            Console.WriteLine($"Certo, {name}. Agora, me informe em que ano estamos, por gentileza:");
            int currentYear = int.Parse(Console.ReadLine());
            Console.WriteLine($"Ok,{name}. Estamos em {currentYear}. Agora me diga, por favor, em que ano você nasceu:");
            int yearOfBirth = int.Parse(Console.ReadLine());
            int currentAge = currentYear - yearOfBirth;
            Console.WriteLine($"Perfeito, {name}. Sua idade é: {currentAge} anos.");
            Console.ReadLine();
        }
    }
}