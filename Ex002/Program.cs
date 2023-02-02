// Прога принимает 2 числа и проверяет, кратно ли первое второму, если нет - выводит остаток


Console.WriteLine();
Console.WriteLine();


Console.WriteLine("Введите первое число");
int Dig1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число");
int Dig2 = int.Parse(Console.ReadLine());

if (Dig1%Dig2==0)
{
    Console.WriteLine("Число "+ Dig1 + " кратно числу " + Dig2);
}
else
{
    Console.WriteLine("Число "+ Dig1 + " не кратно числу " + Dig2);
    Console.WriteLine("Остаток от деления "+ Dig1 + " на " + Dig2 + " равен " + Dig1 % Dig2);
}

Console.WriteLine();
Console.WriteLine();