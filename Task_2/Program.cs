// Задача 2: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int Prompt(string message)
{
    Console.Write(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;
}

int X1 = Prompt("Введите X первой точки координат => ");
int Y1 = Prompt("Введите Y первой точки координат => ");
int Z1 = Prompt("Введите Z первой точки координат => ");
int X2 = Prompt("Введите X второй точки координат => ");
int Y2 = Prompt("Введите Y второй точки координат => ");
int Z2 = Prompt("Введите Z второй точки координат => ");

int DX = X1 - X2;
int DY = Y1 - Y2;
int DZ = Z1 - Z2;
double answer = Math.Sqrt(DX * DX + DY * DY + DZ * DZ);
Console.WriteLine(answer);
