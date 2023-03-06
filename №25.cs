// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
System.Console.WriteLine("Введите основание степени: ");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите степень: ");
int mul = Convert.ToInt32(Console.ReadLine()); 
if (mul <= 0)
{
     System.Console.WriteLine("введите мультипликатор больше чем 0");
}
    else
        {
            System.Console.Write("Число "+(num)+" возводимое в степень "+(mul)+" равняется: " + Math.Pow(num, mul));
        }
