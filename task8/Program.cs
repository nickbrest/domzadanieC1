// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int number = new Random().Next(10, 99);
int numberA = number / 10;
int numberB = number % 10;
int max = numberA;
if (numberB > numberA) max = numberB;
Console.WriteLine(number);
Console.WriteLine(max);
