Console.Clear();

int[] array = { -2, 3, 4, 5, -6, 7 };
int max = array[0];
int min = array[0];

for (int j = 0; j < array.Length; j++)
{
    if (array[j] > max) max = array[j];
    if (array[j] < min) min = array[j];
}
Console.WriteLine();
Console.Write("Разница между максимальным и минимальным элементом массива = ");
Console.Write(max - min);