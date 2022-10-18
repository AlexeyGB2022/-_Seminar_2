Console.WriteLine("Введите трехзначное число");

int numA;
while (!int.TryParse(Console.ReadLine()!, out numA))
{
    Console.WriteLine ("Неверный ввод");
    Console.WriteLine("Введите трехзначное число");
}

void secondN(int numA)
{
    if (numA/100 == 0 || numA/100>=10) 
    {
        Console.WriteLine ("Неверный ввод");
        Console.WriteLine("Перезапустите программу");
    }
    else
    {
        int second = (numA/10)%10;
        Console.WriteLine(second);
    }
}

secondN(numA);