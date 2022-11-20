// Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.

// -2, 1, -7, 5, 19 -> [1, -2, 5, -7, 19]
// 6, 1, -33 -> [1, 6, -33]

void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(-20, 21);
        index++;
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(array[position] + " ");
        position++;
    }
}

void SortingArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (Math.Abs(array[j]) < Math.Abs(array[minPosition]))
                minPosition = j;
        }
        int help = array[i];
        array[i] = array[minPosition];
        array[minPosition] = help;
    }
}

int[] array = new int[8];
FillArray(array);
SortingArray(array);
PrintArray(array);