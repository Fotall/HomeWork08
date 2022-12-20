// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


 float[] array = new float[5];
 Random r = new Random();
 float min = 0;
 float max = 0;

 //Заполняем массив рандомными числами от 0 до 99
 for (int i = 0; i < array.Length; i++)
 {
     array[i] = (float)r.Next(0, 100);
     if ( i == 0 ) min = max = array[i];
         else if (array[i] > max) max = array[i];
         else if (array[i] < min) min = array[i];
     Console.Write($"{array[i]}, ");
 }
 Console.WriteLine("\nРазница между максимальным " + max + " и минимальным " + min + " значениями равна " + (max - min));

