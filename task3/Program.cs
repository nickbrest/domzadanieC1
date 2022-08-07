// Найти максимальное из трех чисел
int a = 15;
int b = 48;
int c = 12;

int max = a;

if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine(max);