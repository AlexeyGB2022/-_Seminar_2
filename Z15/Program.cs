Console.WriteLine("Введите число");

int numA;
while (!int.TryParse(Console.ReadLine()!, out numA))
{
    Console.WriteLine ("Неверный ввод");
    Console.WriteLine("Введите число");
}

void day(int numA)
{
    if (numA<1 || numA>7) 
    {
        Console.WriteLine ("Неверный ввод");
        Console.WriteLine("Перезапустите программу");
    }
    else
    {
        if (numA>0 && numA<6) Console.WriteLine ("Нет");
        else Console.WriteLine ("Да");
    }
}

day(numA);
