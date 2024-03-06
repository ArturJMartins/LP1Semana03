using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {

            string fraseFinal ="";
            Console.Write("String: ");
            string frase = Console.ReadLine();

            Console.Write("\nCaráter: ");
            string caracter = Console.ReadLine();

            char c = char.Parse(caracter);

            for (int i = 0; i < frase.Length; i++)
            {
                if(frase[i] == c)
                {
                    fraseFinal += "X";
                }
                else
                {
                    fraseFinal += frase[i];
                }
            }

            Console.Write($"\nSerá impresso: {fraseFinal}");
        }
    }
}
