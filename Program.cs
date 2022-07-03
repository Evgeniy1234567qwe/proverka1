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

// // Домашнее задание,урок 1
// // 1.Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.Write("Input first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 == num2)
//      Console.Write("The numbers are equal to each other");
// else if (num1 > num2)
//     Console.Write("First number - max, Second number - min");
// else
//     Console.Write("First number - min, Second number - max");


// //2.Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.Write("Input first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input Third number: ");
// int num3 = Convert.ToInt32(Console.ReadLine());
// int max = num1;
// if (num2 > max)max = num2;
// else 
//     max = num1;
// if (num3 > max)max = num3;
//     Console.Write(max);


// // 3.Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num %2 == 0)
//     Console.Write("Четное");
// else
//     Console.Write("Нечетное");


// // 4.Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int current = 2;
// while(current <= num){
//     if (current % 2==0)
//     Console.Write(current + " ");
//     current++;
// }

// // Лекции
// //из одномерного массива array из n элементов, требуется найти элемент массива, равный find

// int [] array = { 21, 22, 23, 24, 25, 26, 72, 82, 92, 210, 26,5 };
// int n = array.Length;
// int find = 26;
// int index = 0;
// while (index < n)
// {
//     if (array[index] == find)
//     {
//     Console.WriteLine(index);
//     break; //-прерви
//     }
//     //index = index + 1;
//     index++;
// }


// void FillArray(int[] collection)

// {
//     int lenght = collection.Length;
//     int index = 0;
//     while (index < lenght)
//     {
//         collection[index] = new Random().Next(1, 10);
//         //index = index + 1;
//         index++;
//     }
// }

// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.WriteLine(col[position]);
//         position++;
//     }
// }

// int IndexOf(int[] colection, int find)
// {
//     int count = colection.Length;
//     int index = 0;
//     int position = 0;


//     while (index < count)
//     {
//         if(colection[index] == find)
//         {
//             position = index;
//             break;
//         }
//         index++;
//     }
//     return position;
// }

// int [] array = new int[10];

// FillArray(array);
// array[3] = 4;
// array[8] = 7;
// PrintArray(array);
// Console.WriteLine();

// int pos = IndexOf(array, 5);
// Console.WriteLine(pos);


// // Домашнее задание,урок 2
// //Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int a = num / 10 % 10;
// Console.WriteLine(a);

// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
int a = num / 100 % 10;
    Console.WriteLine(a);
    if (num < 99)
    Console.Write("Третьей цифры нет");
