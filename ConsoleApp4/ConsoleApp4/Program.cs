using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hei, hva heter du?");

            string userTnput = Console.ReadLine();
            Console.WriteLine("Velkommen " + userTnput + "!");

        }
    }
}
