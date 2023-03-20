

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(NumMethod());

        

        static bool NumMethod()
        {
            int lite = Console.Read();
            Random numb = new Random();
            int number1 = numb.Next(1, 10);
            Console.WriteLine(number1);
            
            if (lite >= number1) ;
            {
                return false;
            } 
            return true;
            
        }
    }


}
    
