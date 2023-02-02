// Программа выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа
Console.WriteLine("");
Console.WriteLine("");

int number = new Random().Next(10, 99);
Console.WriteLine("Число " + number);
int dig1 = number / 10;
int dig2 = number % 10;

if (dig1 != dig2)
{
    if (dig1 > dig2) Console.WriteLine("Большее - " + dig1);
    else Console.WriteLine("Большее - " + dig2);
}
else Console.WriteLine("Числа " + dig1 + " и " + dig2 + " равны ");

Console.WriteLine("");
Console.WriteLine("");