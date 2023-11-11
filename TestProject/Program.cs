for (int currentNumber = 1; currentNumber <= 100; currentNumber ++)
{
    Console.Write($"{currentNumber} ");
    if (currentNumber % 3 == 0)
        Console.Write("Fizz");
    if (currentNumber % 5 == 0)
        Console.Write("Buzz");
    Console.Write("\n");
}