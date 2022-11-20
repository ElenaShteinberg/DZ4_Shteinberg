// Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
int Exponentiate(int numberA, int numberB)
{
    int newNumber = numberA;
    for (int index = 2; index <= numberB; index++)
    {
        newNumber = newNumber * numberA;
    }
    return newNumber;
}
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine(Exponentiate(a, b));
