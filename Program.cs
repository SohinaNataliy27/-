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