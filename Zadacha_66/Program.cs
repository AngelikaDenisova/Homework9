//  Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Введите число m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n");
int n = Convert.ToInt32(Console.ReadLine());

int sum = GetSum(m, n);

int GetSum (int m, int n) 
{
    int sum = 0;
     if (m > n) 
    {
        return sum;
    }
    else
    {
        return sum  = m + GetSum(m + 1, n); 
    }
}
Console.WriteLine(sum);