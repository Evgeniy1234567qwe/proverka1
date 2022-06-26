// // 1.программа, которая на в ход принимает число и выдаёт его квадрат

// Console.Write("Input integer number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int result = num * num ;
// Console.WriteLine( result );

// 2. Программа, принимает 2 числа и проверяет, является ли первое число квадратом второго

// Console.Write("Input first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// int square = num2 * num2;
// if (num1 == square)
//     Console.Write("First number is a square of second number");
// else
//     Console.Write("First number is not a square of second number");


// // 3. Проограмма которая будет выдавать название дня недели по заданому номеру

// Console.Write("Input number of the day: ");
// int day = Convert.ToInt32(Console.ReadLine());
// if (day < 1 || day > 7){
//     Console.Write("Incorrect number"); 
// }
// if (day == 1){
//     Console.Write("Понедельник");
// }
// if (day == 2){
//     Console.Write("Вторник");
// }
// if (day == 3){
//     Console.Write("Среда");
// }
// if (day == 4){
//     Console.Write("Четверг");
// }
// if (day == 5){
//     Console.Write("Пятница");
// }
// if (day == 6){
//     Console.Write("Суббота");
// }
// if (day == 7){
//     Console.Write("Воскресенье");
// }


// // 4. Программа, принимает одно число (N), а на выходи показывает все целые числа в промежутке от -N до N

// Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int current = -1 * num;
// while(current <= num){
//     Console.Write(current + " ");
//     current++;
// }


// // 5. программа принимает на в ход 3 значное число и на выходе показывает последнюю цифру этого числа

// Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int a = num % 10;
// Console.WriteLine(a);


// 1.Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());