// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную 
// степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void Pow (int A, int B)
{
    int A1 = 1;
    for (int i = 1; i<=B; i++) A1 = A1*A;   
    System.Console.WriteLine(A1);
}
System.Console.WriteLine("Введите число А: ");
int X = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число B: ");
int Y = Convert.ToInt32(Console.ReadLine());
System.Console.Write($"Чило {X} в степени {Y} = ");
Pow(X, Y);