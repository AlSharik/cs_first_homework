System.Console.WriteLine("Write number:");
int number = Convert.ToInt32(Console.ReadLine());
int even = 2;
while(even <= number)
{
    System.Console.WriteLine(even);
    even = even + 2;
}