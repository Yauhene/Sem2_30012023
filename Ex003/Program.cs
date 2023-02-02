// Программа выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа
Console.WriteLine("");
Console.WriteLine("");

Random random = new Random(); //- версия с семинара
int min = 10;
int max = 99;

//int number = new Random().Next(10, 100);  - моя версия
//Console.WriteLine("Число " + number);
// int dig1 = number / 10;
// int dig2 = number % 10;

int number = random.Next(min, max+1);
int dig1 = number / 10;
int dig2 = number % 10;
//Console.WriteLine("Число " + number);


if (dig1 != dig2)
{
    //if (dig1 > dig2) Console.WriteLine("Большее - " + dig1); // -- моя версия
    if (dig1 > dig2) Console.WriteLine($"В числе {number} самая большая цифра {dig1}");
    else Console.WriteLine($"В числе {number} самая большая цифра {dig2}"); // - способ собрать строку из текста и значений переменных
}
else Console.WriteLine("Числа " + dig1 + " и " + dig2 + " равны ");



Console.WriteLine("");
Console.WriteLine("");