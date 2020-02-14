using System;

namespace hello
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int[] someOddsNumbers = { 1, 3, 5, 7 };

            //For Loop
            for (int i = 0; i < someOddsNumbers.Length; i ++)
            {
                Console.Write(someOddsNumbers[i]);
            }

            Console.WriteLine();

            //For Each Loop
            foreach(int number in someOddsNumbers)
            {
                Console.Write(number);
            }

            Console.WriteLine();

            string hello = "Eu adoro programar em C#";
            Console.WriteLine(hello.Substring(3, 6));
            Console.WriteLine(hello.Replace("adoro", "amo"));
            Console.WriteLine(hello.ToUpper());

            var pokemon = (name: "Bulbasaur", type: "Water");
            Console.WriteLine(pokemon);
            Console.WriteLine("Seu pokemon chama: " + pokemon.name);

        }
    }
}
