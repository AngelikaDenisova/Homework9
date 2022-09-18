// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""

// M = 4; N = 8. -> ""4, 6, 7, 8""

Console.WriteLine("Введите число m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n");
int n= Convert.ToInt32(Console.ReadLine());


string Natural (int m, int n)
{
    if (m > n)
    {
        if (m==n) return Convert.ToString(m);
        return m + " " + Natural(m-1, n);
    }
    else
    {
      if (m==n) return Convert.ToString(m);
       return m + " " + Natural(m+1, n);  
    }
    
}

 Console.WriteLine(Natural(m, n));
