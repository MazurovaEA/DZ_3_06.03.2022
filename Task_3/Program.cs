// Задача 3: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
int Prompt(string message)
{
    Console.Write(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;
}

int N = Prompt("Введите N => ");
for (int i = 1; i <= N; i++)
{
    Console.Write(i * i * i + " ");
}