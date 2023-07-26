//  1. Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Write("Введите первое число: ");
// int firstDigit = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int secondtDigit = Convert.ToInt32(Console.ReadLine());

// if (firstDigit > secondtDigit)
// {

// Console.WriteLine(" Первое число " + firstDigit + " больше чем второе " + secondtDigit);

// }

// else
// {
// Console.WriteLine (" Второе число " + secondtDigit + " больше чем первое " + firstDigit);

// }

// 2.Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("Введите три числа:");
// int nunmer_one = Convert.ToInt32(Console.ReadLine());
// int nunmer_two = Convert.ToInt32(Console.ReadLine());
// int nunmer_three = Convert.ToInt32(Console.ReadLine());

// int max = nunmer_one;

// if ( nunmer_two > max )

// {
//     max = nunmer_two;
// }
// if ( nunmer_three > max )
// {
//   max = nunmer_three;
// }
// Console.WriteLine("Максимальное->" + max);

// 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine("Введите  число:");
//  int number = Convert.ToInt32(Console.ReadLine());

//  if (number % 2 == 1)
// {
//   Console.WriteLine(" Число " + number + " является: нечетным");
// }
//  else
// {
//   Console.WriteLine(" Число " + number + " является: четным");
// }
// Последнюю задачу не знаю как решать.

// Дз ко 2 семинару.

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// int Prompt(string message)
// {
// Console.WriteLine(message);
// string value = Console.ReadLine();
// int result = Convert.ToInt32(value);
// return result;
// }
// bool IsWeekend (int weekDay)
// {
//     if (weekDay > 5)
//     {
//         return true;
//     }
//     return false;
// }

// bool ValidateWeekday (int number)
// {
//     if (number > 0 && number <= 7)
//     {
//         return true;
//     }
//     Console.WriteLine("Это не день недели!");
// return false;
// }

// int weekDay = Prompt("Введите день недели >");
// if (ValidateWeekday(weekDay))
// {
//     Console.WriteLine("Наконец-то выходной");
// }
// else
// {
//     Console.WriteLine("Придется порабтать");
// }

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


// Console.Clear();
// Console.WriteLine("Задача 10 ");
// Console.Write("Введи трёхзначное число: ");
// int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
// string stringNumber = Convert.ToString(threeDigitNumber);
// Console.WriteLine("вторая цифра этого числа -> "+stringNumber[1]);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.Write("Введи число: ");
// int anyNumber = Convert.ToInt32(Console.ReadLine());
// string anyNumberText = Convert.ToString(anyNumber);
// if (anyNumberText.Length > 2){
//   Console.WriteLine("третья цифра -> " + anyNumberText[2]);
// }
// else {
//   Console.WriteLine("-> третьей цифры нет");
// }

// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// Console.WriteLine("Введите число: ");
// string number = Console.ReadLine();
// int len = number.Length;

// if (len == 5)
// {
//     if (number[0] == number[4] && number[1] == number[3])
//     {
//         Console.WriteLine($"{number} - Палиндром");
//     }
//     else
//     {
//         Console.WriteLine($"{number} - НЕ палиндром");
//     }
// }
// else
// {
//     Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
// }

// 17. Напишите программу, которая принимает на вход координаты точки (X и Y),причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
//  в которой находится эта точка.

// int x = ReadNumber("Введите X: ");
// int y = ReadNumber("Введите Y: ");
// int quadrant = GetQuadrant(x, y);
//  MessageBox.Show($"Точка находится в {quadrant} четверти плоскости.");

//  }
       
// static void Task_10() 
//     {
//         int quadrant = ReadNumber("Введите номер четверти: ");
//          string coordinateRange = GetCoordinateRange(quadrant);
//          MessageBox.Show($"Диапазон координат точек в четверти {quadrant}: {coordinateRange}");
//     }

        
//     static void task_11() 
//      {
        
//         double x1 = ReadNumber("Введите X:");
//          double y1 = ReadNumber("Введите Y:");

       
//         double x2 = ReadNumber("Введите X2:");
//         double y2 = ReadNumber("Введите Y2:");

//         double distance = CalculateDistance(x1, y1, x2, y2);

//         MessageBox.Show($"Расстояние между двумя точками: {distance}");
//         }
//         static void task_12() ;
//         }

  
// //   Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//  int number = ReadNumber("Введите пятизначное число: ");
// bool isPalindrome = IsPalindrome(number);

//  if (isPalindrome)
//     {
//     MessageBox.Show("Число является палиндромом.");
//     }
//  else
//   {
//  MessageBox.Show("Число не является палиндромом.");
//  }
// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//                                 [345, 897, 568, 234] -> 2

//  int[] numbers = new int[4];
// Random random = new Random();
// int countEven = 0;

// for (int i = 0; i < numbers.Length; i++)
//    {
//      numbers[i] = random.Next(100, 1000);
//      if (numbers[i] % 2 == 0)
//     {
//        countEven++;
//     }
//    }

// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// // [-4, -6, 89, 6] -> 0
//  int[] array = new int[4];
//  Random random = new Random();
//  int sum = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = random.Next(-10, 11);
//    if (i % 2 != 0)
//    {
//     sum += array[i];
//    }
//  }



//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2


// Console.WriteLine("Введите длину массива:  ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// RandonNumbers(numbers);
// Console.WriteLine("В этом массиве: ");
// PrintArray(numbers);

// void RandonNumbers(int[] numbers)
// {
//     for(int i = 0; i < size; i++)
//     {
//       numbers[i] = new Random().Next(100,1000);
//     }
// }


// int count = 0;

// for (int x = 0; x < numbers.Length; x++)
// {
// if (numbers[x] % 2 == 0)
// count++;
// }
// Console.WriteLine($"из {numbers.Length} чисел, {count} четных");


// void PrintArray(int[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }

/*
 Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
 значение этого элемента или же указание, что такого элемента нет.
 Во вводе первая цифра - номер строки, вторая - столбца. Цифры не больше 9.
 Например, задан массив:
 1 4 7 2
 5 9 2 3
 8 4 2 4
 17 -> такого числа в массиве нет
 */

// int rows = ReadInt("Введите индекс строки: ");
// int colums = ReadInt("Введите индекс столбца: ");
// int[,] numbers = new int[6, 8];
// FillArray2D(numbers);
// PrintArray2D(numbers);

// if (rows < numbers.GetLength(0) && colums < numbers.GetLength(1)) Console.WriteLine(numbers[rows, colums]);
// else Console.WriteLine($"{rows}{colums} -> такого числа в массиве нет");


// // Заполнение массива рандомными числами от 1 до 9
// void FillArray2D(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// //  Функция вывода массива в терминал
// void PrintArray2D(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// // Функция ввода 
// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//  Например, задан массив:
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
//  5 2 6 7
//  Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
 
 
// int[,] table = new int[4, 4];
// FillArrayRandom(table);
// PrintArray(table);
// Console.WriteLine();
// NumberRowMinSumElements(table);


// // Функция вывода номера строки (не индекса) с наименьшей суммой элементов 
// void NumberRowMinSumElements(int[,] array)
// {
//     int minRow = 0;
//     int minSumRow = 0;
//     int sumRow = 0;
//     for (int i = 0; i < table.GetLength(1); i++)
//     {
//         minRow += table[0, i];
//     }
//     for (int i = 0; i < table.GetLength(0); i++)
//     {
//         for (int j = 0; j < table.GetLength(1); j++) sumRow += table[i, j];
//         if (sumRow < minRow)
//         {
//             minRow = sumRow;
//             minSumRow = i;
//         }
//         sumRow = 0;
//     }
//     Console.Write($"{minSumRow + 1} строка");
// }

// // Функция вывода двумерного массива
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// // Функция заполнения массива рандомно числами от 1 до 9
// void FillArrayRandom(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// // M = 1; N = 15 -> 120
// // M = 4; N = 8. -> 30

// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// SumFromMToN(m, n);

// // вызов функции "сумма чисел от M до N"
// void SumFromMToN(int m, int n)
// {
//     Console.Write(SumMN(m - 1, n));
// }

// // функция сумма чисел от M до N
// int SumMN(int m, int n)
// {
//     int res = m;
//     if (m == n)
//         return 0;
//     else
//     {
//         m++;
//         res = m + SumMN(m, n);
//         return res;
//     }
// }

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// AkkermanFunction(m,n);


// // вызов функции Аккермана
// void AkkermanFunction(int m, int n)
// {
//     Console.Write(Akkerman(m, n)); 
// }

// // функция Аккермана
// int Akkerman(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (n == 0 && m > 0)
//     {
//         return Akkerman(m - 1, 1);
//     }
//     else
//     {
//         return (Akkerman(m - 1, Akkerman(m, n - 1)));
//     }
// }

//Задача 64: Задайте значение N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от N до 1
//Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int n = InputNumbers("Введите N: ");
int count = 2;
PrintNumber(n, count);
Console.Write(1);

void PrintNumber(int n, int count)
{
    if (count > n) return;
    PrintNumber(n, count + 1);
    Console.Write(count + ", ");
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}