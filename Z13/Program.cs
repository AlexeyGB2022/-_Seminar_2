Console.WriteLine("Введите число");

int numA;
while (!int.TryParse(Console.ReadLine()!, out numA))
{
    Console.WriteLine ("Неверный ввод");
    Console.WriteLine("Введите число");
}

    int numA1 = numA;
    double i = 0;
    while (numA>0)
    {
        numA = numA/10;
        i++;
    }

if (i<3) Console.WriteLine("Третьей цифры нет");

else
{
    double i1 = Math.Pow(10, i-3);

    int b = (int)i1;

    int numB = (numA1 / b)%10;
    Console.WriteLine(numB);
}




