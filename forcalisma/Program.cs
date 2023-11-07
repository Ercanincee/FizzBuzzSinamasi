for (int i = 0; i < 101; i++)
{
    if(i%3==0)
    {
        Console.WriteLine(i.ToString()+"Fizz");
    }
    if (i % 5 == 0)
    {
        Console.WriteLine(i.ToString() + "Buzz");
    }
    if(i%5==0&&i%3==0) { Console.WriteLine(i.ToString() + "Fizz" + "Buzz"); }
}
