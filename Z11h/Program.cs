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

if (i<2) Console.WriteLine("Удалять нечего");

else
{
    double i1 = Math.Pow(10, i-1);
    int b = (int)i1;
    int numB = (numA1 / b);
    int numC = (numA1 % (b/10));

    numB = numB * (b/10) + numC;
    
    Console.WriteLine(numB);
}

