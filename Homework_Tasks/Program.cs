/*
Урок 3. Массивы и функции в программировании
/*

/*-----------------------------------------------------------------
Задача 19
Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
-------------------------------------------------------------------
*/

int CheckNumber(string str)
{
    if (!Int32.TryParse(str, out int number))
    {
        number = -1;
        Console.WriteLine($"Введенная строка '{str}' не являются числом\nПопробуйте еще раз, или '0' для выхода");
    }
    return number;
}


bool CheckExit(int num)
{
    if (num == 0)
    {
        Console.WriteLine("\nРабота с программой завершена, До встречи!\n");
        return true;
    }
    return false;
}

// Осночное тело программы
// для упрощение на значность число не проверям, не обрезаем и не достраиваем
// =======================

Console.WriteLine("Определение Палиндрома");
Console.WriteLine("---");

while (true)
{
    Console.WriteLine("Введите пятизначное число или '0' для завершения:");
    string? str_number = Convert.ToString(Console.ReadLine());
    int number = CheckNumber(str_number);
    if (number < 0)
        continue;
    if (CheckExit(number))
        break;

    string str_reverse = new string(str_number.ToCharArray().Reverse().ToArray());
    if (str_number == str_reverse)    // Проверить число на Палиндром 
        Console.WriteLine($"число {str_number} == {str_reverse} - палиндром");
    else
        Console.WriteLine($"число {str_number} <> {str_reverse} - НЕТ");
}
// *** Конец Задачи 19 ***


/*-------------------------------------------------------------------
Задача 21
Напишите программу, которая принимает на вход координаты 
двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
-------------------------------------------------------------------
*/

void Distance_TwoPoints(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double xLen = x1 - x2;
    double yLen = y1 - y2;
    double zLen = z1 - z2;
    double length = Math.Round(Math.Sqrt(xLen * xLen + yLen * yLen + zLen * zLen), 2);
    Console.WriteLine($"Расстояние между точками ({x1}, {y1}, {z1}) и ({x2}, {y2}, {z2}) в 3D пространстве = {length}");
}

Console.WriteLine("Для рассчета расстояния между 2-мя точками в 3D пространстве Введедите их координаты");
Console.WriteLine("---");
while (true)
{
    double x1, y1, z1, x2, y2, z2 = 0;
    Console.WriteLine("Координаты 1-й точки:");
    Console.Write("X1 = ");
    x1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Y1 = ");
    y1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Z1 = ");
    z1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Координаты 2-й точки:");
    Console.Write("X2 = ");
    x2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Y2 = ");
    y2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Z2 = ");
    z2 = Convert.ToInt32(Console.ReadLine());

    Distance_TwoPoints(x1, y1, z1, x2, y2, z2);
    Console.WriteLine("");

    Console.WriteLine("Продолжить? ('Y' - да, 'N' - нет)");
    char chr_continue = Convert.ToChar(Console.ReadLine());
    if (chr_continue.Equals('N'))
        break;
}
Console.WriteLine("До встречи!");
// *** Конец Задачи 21 ***


/*-------------------------------------------------------------------
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
-------------------------------------------------------------------
*/
void GetCube(int number, int power)
{
    for (int i = 1; i < number + 1; i++)
        Console.Write($"{Math.Pow(i, power)}, ");
}

int number_max = 100;
Console.WriteLine(@"Покажу все квадраты чисел от 1 до указанного числа.
                    Введите целое число (не более 100). 
                    Для завершения введите '0'");
Console.WriteLine("---");
while (true)
{
    int number = Math.Min(number_max, Convert.ToInt32(Console.ReadLine()));
    if (number == 0)
        break;
    else
        GetCube(number, 3);
    Console.WriteLine("");
}
Console.WriteLine("До встречи!");
// *** Конец Задачи 23 ***
