// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void Array(int[] zero)
{
    for (int i = 0; i < zero.Length; i++)
    {
        zero[i] = new Random().Next(-99, 99); // поставил ограничение,
        // а то генерирует числа в миллионы, не удобно проверять, хоть и по заданию нет предела
    }
}
void PrintArray(int[] one)
{
    for (int i = 0; i < one.Length; i++)
    {
        Console.Write(one[i] + " ");
    }
}

Console.Write("Кол-во элементов в массиве: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
Array(array);
PrintArray(array);

int sum = 0;
for (int i = 1; i < array.Length; i++)
{
    sum += array[i];
    i++;

}
 Console.WriteLine($"-> {sum}");