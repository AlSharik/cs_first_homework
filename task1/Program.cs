System.Console.WriteLine("Write numbers:");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 > number2)
{
    Console.WriteLine($"max={number1} and min={number2}");
}
else if(number1 < number2)
{
    Console.WriteLine($"max={number2} and min={number1}");
}
else
{
    System.Console.WriteLine($"They are equals and value {number1}");
}
