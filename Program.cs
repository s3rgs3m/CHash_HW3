// https://github.com/s3rgs3m/CHash_HW3
// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.Write ("Введите номер задачи 19, 21 или 23: ");
if (int.TryParse(Console.ReadLine(), out int taskNum)){
    switch (taskNum) {
        case 19: //Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
            Console.Clear();
            Console.WriteLine("Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
            Console.Write("\nВведите число: ");
            if (int.TryParse(Console.ReadLine(), out int number19))
                if (number19 < 10000 || number19 > 99999)
                    Console.WriteLine ("Число должно быть пятизначным");
                else{
                    string strNum = number19.ToString();
                    if (strNum[0] == strNum[4] && strNum[1] == strNum[3])
                        Console.WriteLine ($"Число '{number19}' - это палиндром");
                    else
                        Console.WriteLine ($"Число '{number19}' - это не палиндром");
                }
            else
                Console.WriteLine ("Число введено неправильно");
            break;

        case 21: // Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
        // формула: AB = ((Xb - Xa)^2 + (Yb - Ya)^2 + (Zb - Za)^2)^1/2
            Console.Clear();
            Console.WriteLine("Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
/*                Console.Write("\nВведите цифру: ");
                if (int.TryParse(Console.ReadLine(), out int number13)){
                    // решение через string:
                    Console.WriteLine("Решение через массив в String:");
                    string str = number13.ToString();
                    Console.WriteLine (str.Length > 2 ? $"\tТретья цифра в числе '{str}': {str[2]}" : $"\tВ числе '{str}' нет 3й цифры");

                    //решение без массива:
                    Console.WriteLine("\nРешение без массива:");
                    if (number13 / 100 >0 ){

                        int third = 0;
                        int partOfNumber = number13;
                        
                        while (partOfNumber > 99){
                            third = partOfNumber % 10;
                            partOfNumber = partOfNumber / 10;
                        }
                        Console.WriteLine($"\tТретья цифра в числе '{number13}': {third}");
                    }
                    else 
                        Console.WriteLine ($"\tВ числе '{number13}' нет 3й цифры");
                }
                else
                Console.WriteLine ("Введено не число int");
 */
            break;

        case 23: // Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
            Console.Clear();
            Console.WriteLine("Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
                Console.Write("\nВведите число N: ");
                if (int.TryParse(Console.ReadLine(), out int number23) && (number23 >0))
                        for (int i=1; i <= number23;i++)
                            Console.Write(i > 1 ? $", {Math.Pow(i,3)}" : $"\n{Math.Pow(i,3)}");
                else
                    Console.WriteLine ("Число N введено неправильно");       
            break;
        default:
            Console.WriteLine("Такого номера задачи нет");
            break;
    }
}
else
    Console.WriteLine ("Введен не номер задачи");
