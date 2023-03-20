namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyFor();
            MyForeach();
            Mywhile();
            Console.WriteLine("-------------------------------------------");
            MymLoop();
            MymForeach();
            MymWhile();
        }

        public static void MyFor()
        {
            string[] args = { "eller", "hva", "når" };
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
        }


        public static void MyForeach()
        {
            string[] args = { "dette", "er", "gøy" };
            foreach (var arg in args)
            {
                Console.WriteLine(arg);
            }
        }

        public static void Mywhile()
        {
            bool condition = true;
            int i = 0;
            while (condition)
            {
                if (i < 10) // dersom i er mindre enn 10 printer vi ut at Terje er kul, og øker i med 1
                {
                    Console.WriteLine("Terje er Kul");
                    i++;
                }
                else // dersom i er 10 eller mer vil man sette condition til false
                {
                    condition = false; // når denne linjen har kjørt vil while løkken avsluttes
                }
            }
        }

        public static void MymLoop(){
            string args =  "Terje er Kul" ;
            for (int i = 0; i < 5; i++) Console.WriteLine(args);
        }

        public static void MymForeach()
        {
            string args = "Det snør det snør tideli bom, Det er det det gjør tideli bom, nå snør det mye mer en før tideli bom og hutte meg tu!";
            foreach (var arg in args) Console.WriteLine(arg);

        }

        public static void MymWhile()
        {
            int i = 0;
            while (i <= 10) Console.WriteLine("Runde nr" +  i++);
              
        }

    }
}