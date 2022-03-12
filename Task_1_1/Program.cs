//Задача 1: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//Вариант 3 - решение с помощью строки для любых чисел.
Console.Write("Введите число: ");
string K = Console.ReadLine();
string M = "";
    for (int i = K.Length - 1; i >= 0; i--)
    {
        M += K[i];
    }
    if (K != M) Console.WriteLine($"Введенное число НЕ является палиндромом");
    else Console.WriteLine($"Введенное число является палиндромом");

//Вариант 4 - решение с помощью массива для любых чисел.
Console.Write("Введите число => ");
string Number = Console.ReadLine();
int[] arr1 = new int[Number.Length];
for (int i = 0; i < Number.Length-1; i++)
{
    arr1[i] = Convert.ToInt32(Number.Substring(i, 1));
}
    int[] arr2 = new int[Number.Length];

    for (int k = 0; k <= arr1.Length - 1; k++)
    {
        arr2[k] = arr1[arr1.Length - k - 1];
    }

    if ((arr1[0] == arr2[0]) && (arr1[1] == arr2[1]) && (arr1[2] == arr2[2]) && (arr1[3] == arr2[3]) && (arr1[4] == arr2[4])) Console.WriteLine("Введенное число является палиндромом");
    else Console.WriteLine("Введенное число НЕ является палиндромом");
