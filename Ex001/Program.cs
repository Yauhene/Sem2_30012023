﻿// Получить случайное 3-значное число, выделить первую и последнюю цифры и создать из них двузначное число
Console.WriteLine("Введите число");
int num = new Random().Next(100,999);
//if(int.TryParse(ReadLine(), out int num));
//{
    //Console.WriteLine("Введите число");
//}
Console.WriteLine(num);
int first = num % 10;
Console.WriteLine(first);
int third = num / 100;
Console.WriteLine(third);
int res=first+third*10;
Console.WriteLine(res);

