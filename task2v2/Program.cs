// По заданному номеру дня недели вывести его название
Console.Write("Введите номер дня недели ");
int numberDen = int.Parse(Console.ReadLine());
if (numberDen == 1)
{
    Console.WriteLine("понедельник");
}
if (numberDen == 2)
{
    Console.WriteLine("вторник");
}
if (numberDen == 3)
{
    Console.WriteLine("среда");
}
if (numberDen == 4)
{
    Console.WriteLine("четверг");
}
if (numberDen == 5)
{
    Console.WriteLine("пятница");
}
if (numberDen == 6)
{
    Console.WriteLine("суббота");
}
if (numberDen == 7)
{
    Console.WriteLine("воскресенье");
}
if (numberDen > 7)
{
    Console.WriteLine("Идиот, в неделе 7 дней");
}
