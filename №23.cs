// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
System.Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int N = number % 10;
if (number < 99)
{
    System.Console.WriteLine("Отсутствует наличие третьего числа, попробуйте снова ");
}

else
{
    while (number > 999)
    
     {
        number = number/10;
        }
        number =number%10;
        System.Console.WriteLine(number);
    
}