using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        static int customerNumber = 523242;
        static string custumerInfo = "KundeNavn: Kåre Berntsen";
        static bool isCustomer = true;

        static void Main(string[] args)
        {
            Console.WriteLine(GetCounter());
            Console.WriteLine(GetSomething());
            Console.WriteLine(GetCounter() + GetSomething());

            Console.WriteLine(Getingenthing());

        }

        static int GetCustomerNumber()
        { 
            return customerNumber; 
        }
        static int GetCounter()
        {
            int counter = 0;
            counter = counter + 5;
            return counter;
        }

        static int GetSomething()
        {
            int something = 5 * 3;
            return something;

        }
        static string Getingenthing()
        {
            string returIngenTing = "Denne metoden returnerer ingenting";

            return returIngenTing;
        }

    }
}