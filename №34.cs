// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int[4];
Random rand = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(100, 999);
}
System.Console.WriteLine("[" + string.Join(", ", array) + "]");

int count = 0;
for (int j = 0; j < array.Length; j++)
    if (array[j] % 2 == 0)
        count++;
{
    System.Console.WriteLine($"Чётных чисел в массиве: {count}");
}
