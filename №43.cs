// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}
double Prompt(string message)
{
  Console.Write(message);
  double num = Convert.ToDouble(Console.ReadLine()!);
  return num;
}
int[] InputArray(string text)
{
    System.Console.WriteLine(text);
    return  Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
}
void GetPoint(double k1, double b1, double k2, double b2)
{
  double x = (b1 - b2) / (k2 - k1);

  double cut1 = k1 * x + b1;
  double cut2 = k2 * x + b2;
  Console.Write($" -> ({cut1}; {cut2})");
}
double k1 = Prompt($"Enter the number k1: ");
double b1 = Prompt($"Enter the number b1: ");
double k2 = Prompt($"Enter the number k2: ");
double b2 = Prompt($"Enter the number b2: ");
Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} ");
GetPoint(k1, b1, k2, b2);
