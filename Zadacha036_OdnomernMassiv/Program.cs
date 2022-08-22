Console.Clear();
int[] array = new int[10];
int count = 0;
Console.Write("[ ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-100, 100);
    Console.Write(array[i] + ", ");
}
for (int j = 0; j < array.Length; j++)
{
    if (j % 2 == 1) count = count + array[j];
}
Console.WriteLine("]");
Console.Write("Сумма чисел стоящих на нечетной позиции в массиве = ");
Console.Write(count);