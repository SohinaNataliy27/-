﻿//  1. Напишите программу, которая на вход принимает два числа и выдаёт,
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


Console.WriteLine("Введите длину массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
RandonNumbers(numbers);
Console.WriteLine("В этом массиве: ");
PrintArray(numbers);

void RandonNumbers(int[] numbers)
{
    for(int i = 0; i < size; i++)
    {
      numbers[i] = new Random().Next(100,1000);
    }
}


int count = 0;

for (int x = 0; x < numbers.Length; x++)
{
if (numbers[x] % 2 == 0)
count++;
}
Console.WriteLine($"из {numbers.Length} чисел, {count} четных");


void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}