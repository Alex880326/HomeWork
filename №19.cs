// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
System.Console.WriteLine("Введите пятизначное число " );
string? number = Console.ReadLine();
int firstNum = Convert.ToInt32(Convert.ToString(number![0]));
int fivthNum = Convert.ToInt32(Convert.ToString(number![4]));
if (number!.Length < 5 || number!.Length > 5)
{
        System.Console.WriteLine("Вы ввели число содержащее больше или меньше пяти цифр.");
}
else
    {
     if (firstNum == fivthNum)
    {
        System.Console.WriteLine("Поздравляю, Ваше число является палиндромом!");
    }
     if (firstNum != fivthNum)
        System.Console.WriteLine("К сожалению, Ваше число не является палиндромом!");
    }
