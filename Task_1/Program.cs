//Задача 1: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//Вариант 1 - решение с помощью строки.
Console.Write("Введите пятизначное число: ");
string A = Console.ReadLine();
string N = "";
if (A.Length != 5) Console.WriteLine($"Введенное число не является пятизначным");
else
{
    for (int i = A.Length - 1; i >= 0; i--)
    {
        N += A[i];
    }
    if (A != N) Console.WriteLine($"Введенное число НЕ является палиндромом");
    else Console.WriteLine($"Введенное число является палиндромом");
}

//Вариант 2 - решение с помощью массива.
Console.Write("Введите пятизначное число => ");
string Number = Console.ReadLine();
int[] arr1 = new int[Number.Length];
for (int i = 0; i < Number.Length; i++)
{
    arr1[i] = Convert.ToInt32(Number.Substring(i, 1));
}
if (arr1.Length != 5) Console.WriteLine($"Введенное число не является пятизначным");
else
{
    int[] arr2 = new int[5];

    for (int k = 0; k <= arr1.Length - 1; k++)
    {
        arr2[k] = arr1[arr1.Length - k - 1];
    }

    if ((arr1[0] == arr2[0]) && (arr1[1] == arr2[1]) && (arr1[2] == arr2[2]) && (arr1[3] == arr2[3]) && (arr1[4] == arr2[4])) Console.WriteLine("Введенное число является палиндромом");
    else Console.WriteLine("Введенное число НЕ является палиндромом");
}