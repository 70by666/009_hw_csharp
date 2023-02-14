// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
// но мне кажется, сумма между 4 и 8 это 26, то есть в условии m - 1 не нужно
int task_65(int m, int n)
{
    if (n == m - 1)
    {   
        return 0;
    }

    return n + task_65(m, n - 1);
}


System.Console.WriteLine(task_65(1, 15));
System.Console.WriteLine(task_65(4, 8));


System.Console.WriteLine("#######");


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int task_68(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return task_68(m - 1, 1);
    }
    if (m > 0 && n > 0)
    {
        return task_68(m - 1, task_68(m, n - 1));
    }

    return 0;
}


System.Console.WriteLine(task_68(2, 3));
System.Console.WriteLine(task_68(3, 2));
