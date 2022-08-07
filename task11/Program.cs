// Найти третью цифру числа или сообщить, что её нет 
int numberR = new Random().Next(-10000, 10000);
Console.WriteLine(numberR);
int number = Math.Abs(numberR);
if (number < 100)
{
Console.WriteLine("В заданном числе 3 цифра отсутствует");
}
else
{
    while (number >= 1000)
        {
        number = number / 10;
        }
    number = number % 10;
}
Console.WriteLine(number);

// (это если отсчет цифр вести слева, если справа, то число поделить на 100 и потом остаток от деления на 10 взять. без цикла)