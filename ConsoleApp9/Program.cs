var dateOnly = DateOnly.FromDateTime(DateTime.Now);
var timeOnly = TimeOnly.FromDateTime(DateTime.Now);


Console.WriteLine(timeOnly.ToString("%h"));

int hour = timeOnly.Hour;

Console.WriteLine(dateOnly);
Console.WriteLine(timeOnly);

Console.WriteLine(hour);
if (hour < 10)
{
    Console.WriteLine("Good morning.");
}
else if (hour < 20)
{
    Console.WriteLine("Good day.");
}
else
{
    Console.WriteLine("Good evening.");
}