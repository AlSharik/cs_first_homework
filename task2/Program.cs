System.Console.WriteLine("Write numbers:");
//int []array = {Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())};
for(int n = 0; n < 3; n++)
{
    array[n] = Convert.ToInt32(Console.ReadLine());
}

for(int n = 0; n < 3; n++)
{
    if(n != 2 && array[n] > array[n+1])
    {
        array[n+1] = array[n];
    }
}
System.Console.WriteLine($"Max value {array[2]}");

