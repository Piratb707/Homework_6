Console.WriteLine("Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 0, 7, 8, -2, -2 -> 2 1, -7, 567, 89, 223-> 3");
Console.WriteLine("Нажмите клавишу Enter");
Console.ReadLine();

int count = 0;
Console.WriteLine("Введите количество чисел: ");
int m = int.Parse(Console.ReadLine());

for (int i = 0; i < m; i++)
{
    Console.WriteLine("Введите число: ");
    int num = int.Parse(Console.ReadLine());
    if (num >= 0)
    {
        count++;
    }
}
Console.WriteLine("Количество чисел больше или равно 0: " + count);
Console.WriteLine("Нажмите клавишу Enter");
Console.ReadLine();

Console.WriteLine("Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)");
Console.WriteLine("Нажмите клавишу Enter");
Console.ReadLine();

double k1, b1, k2, b2, x, y;

Console.WriteLine("Введите коэффициент k1: ");
k1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите свободный член b1: ");
b1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите коэффициент k2: ");
k2 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите свободный член b2: ");
b2 = double.Parse(Console.ReadLine());

x = (b2 - b1) / (k1 - k2);
y = k1 * x + b1;

Console.WriteLine("Точка пересечения двух прямых: (" + x + "," + y + ")");
