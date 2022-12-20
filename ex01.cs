// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void FillArray(int[] zero) //Заполнение массива
{
    for (int i = 0; i < zero.Length; i++)
    {
        zero[i] = new Random().Next(99, 999);
    }
}
void PrintArray(int[] one) //Вывод массива
{
    for (int i = 0; i < one.Length; i++)
    {
        Console.Write(one[i] + " ");
    }
}
Console.Write("Кол-во элементов в массиве: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
FillArray(array);
PrintArray(array);

int res = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0) res++;
}
 Console.WriteLine($"-> {res}");

