// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
double[] numbers = new double[6];
FillArrayRandomNumbers(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max) 
        {
            max = numbers[i];
        }
    if (numbers[i] < min)
        {
            min = numbers[i];
        }
}
System.Console.WriteLine("[" + string.Join(", ", numbers) + "]");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");
void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
