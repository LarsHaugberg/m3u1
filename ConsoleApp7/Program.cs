using ConsoleApp7;

PersonModel p = new();

if (p.FirstName is not null)
{
int length  = p.FirstName.Length;
Console.WriteLine(length);
}
else
{
    Console.WriteLine("No Name!");
}
