using System;

namespace Ex05
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Sr. José. Informe qual o peso em quilos(Kg) de peixe pescado hoje:");
            int maxQuantity = 50;
            string response;

            do
            {
                int quantity;
                while (!int.TryParse(Console.ReadLine(), out quantity))
                {
                    Console.WriteLine("Por favor, digite um número:");
                }

                if (quantity <= maxQuantity ||quantity == 0)
                {
                    Console.WriteLine("Mandou muito bem, Sr. José. Sem multa por aqui!");
                }
                else
                {
                    int excessKg = quantity - maxQuantity;
                    int penalty = excessKg * 4;

                    Console.WriteLine($"A quantidade de quilos(kg) excedente foi de: {excessKg} kg");
                    Console.WriteLine($"Valor total da multa foi de: R$ {penalty} reais.");
                }

                Console.WriteLine("Deseja tentar novamente? (s/n)");
                response = Console.ReadLine();
            } while (response != "n");

            Console.ReadLine();
        }
    }
}
