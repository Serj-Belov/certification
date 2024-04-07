// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

// int M = 5;
// int N = 15;

// void numbersInBetween(int start, int stop)
// {
    
//      if (start == stop) return;
//     System.Console.Write($"{start} ");
//     numbersInBetween(start + 1, stop);
// }

// numbersInBetween(M,N);


// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.



// int [] myArray = {2, 4, 5, 1, 7};
// void Reversal(int[] myArray, int i = 0)
// {
//     if (i < myArray.Length)
//     {
//         Reversal(myArray, i+1);
//         System.Console.Write($"{myArray[i]} " );   
//     }

// }

// void Print(string[] args)
// {
//     int [] myArray = {2, 4, 5, 1, 7};
//     Reversal(myArray);
   
// }
// Print(args);

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

//     System.Console.WriteLine("Введите n: ");
//     int n = Convert.ToInt32(Console.ReadLine()!);
//     System.Console.WriteLine("Введите m: ");
//     int m = Convert.ToInt32(Console.ReadLine()!);
//     int result = Ackerman(n,m);
//     System.Console.WriteLine($"Результат функции Акермана: {result}");


// int Ackerman(int m, int n)
// {
//     if ( m == 0)
//     {
//         return n + 1;
//     }
//     else if (m > 0 && n ==0)
//     {
//         return Ackerman(m - 1, 1);
//     }
//     else if ( m > 0 && n > 0)
//     {
//         return Ackerman(m - 1, Ackerman(m, n - 1));
//     }
//     else
//     {
//         return 0;
//     }
// }
