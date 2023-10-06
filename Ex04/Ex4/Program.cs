using System;

namespace ex4
    {
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Eai, tudo bem? Informa seu nome, por favor:");
            string name = Console.ReadLine();
            Console.WriteLine($"Certo, {name}. Quanto reais você tem para que a gente possa converter. Lembrando: cada dólar está valendo R$5,5. E cada euro R$6,5.");
            if (float.TryParse(Console.ReadLine(), out float totalCash))
            {
                float dolar = totalCash / 5.5f;
                float euro = totalCash / 6.5f;

                dolar = (float)Math.Round(dolar, 2);
                euro = (float)Math.Round(euro, 2);
                Console.WriteLine($"Ok, {name}. Com o montante de R${totalCash}, você terá aproximadamente: {dolar} dolares, ou {euro} euros.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Por favor, insira um valor válido em reais.");
            }
            Console.ReadLine(); 
        }
    }

}