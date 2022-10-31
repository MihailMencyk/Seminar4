// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11 // 82 -> 10 // 9012 -> 12

int Sum (int N)
{
int znak = 0;
for (int i=1; i<N; i = i*10) znak = znak + 1;
int Sum1 = N/Convert.ToInt32(Math.Pow(10, znak-1));
int Sum2 = 0;
int Sum3 = 0;
int result =0;
for (znak = znak; znak>1; znak = znak-1) 
{
    Sum2 = (N/Convert.ToInt32(Math.Pow(10, znak-2)))%10;
    Sum3 = Sum3 + Sum2;
}
result = Sum3+Sum1;
return result;
}
System.Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int finish = Sum (N);
System.Console.WriteLine(finish);