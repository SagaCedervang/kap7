using System;
using System.Collections.Generic;

namespace kap7
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 7.1
            List<string> städer = new List<string>();
            string stad = "0";

            Console.WriteLine("Skriv in hur många städer du vill, lämna en rad tom om du inte vill skriva in fler ");

            while(stad != "")
            {
                stad = Console.ReadLine();
                städer.Add(stad);
            }

            städer.Sort();

            Console.WriteLine("Du har skrivit in städerna:");
            foreach (string by in städer)
            {
                Console.WriteLine(by);
            }
            */
            /* 7.2
            List<int> tal = new List<int>();
            int nyttTal = 0;
            int nyttTal1 = 0;
            int nyttTal2 = 0;

            Console.WriteLine("Skriv in 5 tal");
            for (int i = 0; i < 5; i++)
            {
                nyttTal = int.Parse(Console.ReadLine());
                tal.Add(nyttTal);
            }

            Console.WriteLine("Skriv in två tal:");
            nyttTal1 = int.Parse(Console.ReadLine());
            nyttTal2 = int.Parse(Console.ReadLine());

            if (tal.Contains(nyttTal1) && tal.Contains(nyttTal2))
            {
                Console.WriteLine($"Båda talen finns i listan");
            }

            else
            {
                Console.WriteLine("Minst ett av talen finns i listan");
            }
            */
            /* 7.3
            List<char> tecken = new List<char>();
            Console.WriteLine("Skriv in vad som helst");
            string text = Console.ReadLine();

            foreach(char bokstav in text)
            {
                if (tecken.Contains(bokstav) == false)
                {
                    tecken.Add(bokstav);
                }
            }

            tecken.Sort();

            foreach (char karaktär in tecken)
            {
                Console.WriteLine(karaktär);
            }
            */

            Dictionary<string, string> ord = new Dictionary<string, string>();

            ord["dator"] = "computer";
            ord["hej"] = "hello";
            ord["mus"] = "mouse";
            ord["tangentbord"] = "keyboard";

            Console.WriteLine("Skriv ett av orden: hej, dator, tangentbord eller mus");

        }

    }
}
