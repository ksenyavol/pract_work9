// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Sum(int numberN, int numberM)  
{  
    if (numberN > numberM) return 0;  
    return numberM + Sum(numberN, numberM - 1);  
  
}  
  
Console.Write("Введите число M: ");  
int n = Convert.ToInt32(Console.ReadLine());  
Console.Write("Введите число N: ");  
int m = Convert.ToInt32(Console.ReadLine());  
int sum = Sum(n, m);  
Console.WriteLine(sum);
