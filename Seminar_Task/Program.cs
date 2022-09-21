/* Тема Урока-3 (семинар)
Массивы и функции в программировании
*/

/*
Задача-1.  Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
*/

int FindQuadrants(double x, double y)
{
    if (x>0 && y>0) return 1;
    if (x<0 && y>0) return 2;
    if (x<0 && y<0) return 3;
    if (x>0 && y<0) return 4;
    return 0;
}

Console.Write("Input x coordonste: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y coordonste: ");
double yA = Convert.ToDouble(Console.ReadLine());

int quadrant = FindQuadrants(xA, yA);
Console.WriteLine($"number of quadrant is {quadrant}");


/*
---------------
Задача-2-1.  Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).
*/

void GetRangeQudrand(int quarter)
{
    string str_infinity = "бесконечность"; // "∞"
    string signX, signY;
    List<double> numbersQuadrant = new List<double>() { 1, 2, 3, 4 };
    // numbersQuadrant.ForEach(i => Console.Write($"{i}; "));

    if (!numbersQuadrant.Contains(quarter))
    {
        Console.WriteLine("Не верный ввод. Попробуйте еще раз, или '0' для завершения");
        return;
    }
    signX = quarter == 1 || quarter == 4 ? "+" : "-";
    signY = quarter == 1 || quarter == 2 ? "+" : "-";
    Console.WriteLine($@"В {quarter}-й четверти возможны координаты точек: 
                         X = (0, ... {signX} {str_infinity})
                         Y = (0, ... {signY} {str_infinity})");
    return;
}

Console.WriteLine("Введите номер четверти координатной плоскости (1,2,3 или 4). Для завершения введите '0'");
Console.WriteLine("---");
while (true)
{
    int quarter = Convert.ToInt32(Console.ReadLine());
    if (quarter == 0)
        break;
    else
        GetRangeQudrand(quarter);
}
Console.WriteLine("До встречи!");


/*
---------------
Задача-2-2. Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу квадратов чисел от 1 до N.
*/

void GetSquares(int number)
{
    for (int i=1; i<number+1; i++) 
        Console.Write($"{i*i}, ");
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
        GetSquares(number);
        Console.WriteLine("");
}
Console.WriteLine("До встречи!");


/*
---------------
Задача-2-3. Напишите программу, которая принимает на вход координаты 
двух точек и находит расстояние между ними в 2D пространстве..
*/

void Distance_TwoPoints(double x1, double y1, double x2, double y2) 
{
    double xLen = x1 - x2;
    double yLen = y1 - y2;
    double length = Math.Round(Math.Sqrt(xLen*xLen + yLen*yLen), 1);
    Console.WriteLine($"Расстояние между точками ({x1}, {y1}) и ({x2}, {y2}) в 2D пространстве = {length}");
}

Console.WriteLine(@"Для рассчета расстояния между 2-мя точками в 2D пространстве Введедите их координате");
Console.WriteLine("---");
while (true)
{
    double x1, x2, y1, y2 = 0;
    Console.WriteLine("Координаты 1-й точки:");
    Console.Write("X1 = "); 
    x1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Y1 = "); 
    y1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Координаты 2-й точки:");
    Console.Write("X2 = "); 
    x2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Y2 = "); 
    y2 = Convert.ToInt32(Console.ReadLine());

    Distance_TwoPoints(x1, y1, x2, y2);
    Console.WriteLine("");

    Console.WriteLine("Продолжить? ('Y' - да, 'N' - нет)");
    char chr_continue = Convert.ToChar(Console.ReadLine());
     if (chr_continue.Equals('N'))
        break;
}
Console.WriteLine("До встречи!");