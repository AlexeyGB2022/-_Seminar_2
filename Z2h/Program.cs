Console.WriteLine("Введите число");

int numA;
while (!int.TryParse(Console.ReadLine()!, out numA))
{
    Console.WriteLine ("Неверный ввод");
    Console.WriteLine("Введите число");
}

if (numA > 4 && numA < 21 || numA % 10 == 0) Console.WriteLine(numA + " программистов ");
else if (numA % 10 == 1) Console.WriteLine(numA + " программист");
else if (numA % 10 > 1 && numA % 10 < 5) Console.WriteLine(numA + " программиста ");
else if (numA % 10 > 4) Console.WriteLine(numA + " программистов ");
