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
                    Console.WriteLine ("С массивом string"); // Решение через string
                    string strNum = number19.ToString();
                    if (strNum[0] == strNum[4] && strNum[1] == strNum[3])
                        Console.WriteLine ($"\tЧисло '{number19}' - это палиндром");
                    else
                        Console.WriteLine ($"\tЧисло '{number19}' - это не палиндром");

                    Console.WriteLine ("Через деление и остаток от деления"); // Решение через деление
                    if ((number19 / 10000 == number19 % 10) && ((number19 / 1000) % 10 == (number19 % 100) / 10))
                        Console.WriteLine ($"\tЧисло '{number19}' - это палиндром");
                    else
                        Console.WriteLine ($"\tЧисло '{number19}' - это не палиндром");
                }
            else
                Console.WriteLine ("Число введено неправильно");
            break;

        case 21: // Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
        // формула: AB = ((Xb - Xa)^2 + (Yb - Ya)^2 + (Zb - Za)^2)^1/2
            Console.Clear();
            Console.WriteLine("Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
            Console.Write("\nВведите координаты 1й точки в виде 'Х, Y, Z': ");
            string [] point = {""};
            int x1, y1, z1, x2, y2, z2;
            point = Console.ReadLine().Split(',','.');
            while (!(int.TryParse(point[0].Trim(), out x1) && int.TryParse(point[1].Trim(), out y1) && int.TryParse(point[2].Trim(), out z1))){
                Console.Write("Введите координаты 1й точки в виде 'Х, Y, Z': ");
                point = Console.ReadLine().Split(',','.');
            }
            Console.Write("\nВведите координаты 2й точки в виде 'Х, Y, Z': ");
            point = Console.ReadLine().Split(',','.');
            while (!(int.TryParse(point[0].Trim(), out x2) && int.TryParse(point[1].Trim(), out y2) && int.TryParse(point[2].Trim(), out z2))){
                Console.Write("Введите координаты 2й точки в виде 'Х, Y, Z': ");
                point = Console.ReadLine().Split(',','.');
            }
            double rng = Math.Round(Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2)),2);
            Console.WriteLine ($"Расстояние между точками ({x1}, {y1}, {z1}) и ({x2}, {y2}, {z2}) = {rng}");

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
