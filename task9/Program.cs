// Удалить вторую цифру трёхзначного числа
int number = 459;
int number1 = number / 100;
int number3 = number % 10;
Console.WriteLine(number1 * 10 + number3);