// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// System.Console.WriteLine("Введите число " );
// string? number = Console.ReadLine();
int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}
int Sum(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num = num /10;
    }
    return sum;
}
int num = ReadInt("Введите желаемое число: ");
System.Console.WriteLine($"Сумма цифр в числе {num} = {Sum(num)}");
