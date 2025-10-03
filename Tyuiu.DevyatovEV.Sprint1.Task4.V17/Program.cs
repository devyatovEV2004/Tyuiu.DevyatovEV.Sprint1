using Tyuiu.DevyatovEV.Sprint1.Task4.V17.Lib;

Console.Title = "Спринт #1 | Выполнил: Девятов Егор | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #17                                                             *");
Console.WriteLine("* Выполнил: Девятов Егор | ИСТНб-25-1                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая вычисляет результат по формуле:             *");
Console.WriteLine("*          1                                                              *");
Console.WriteLine("* z = -----------                                                         *");
Console.WriteLine("*      √(x - 5y)                                                          *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.Write("Введите значение X: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение Y: ");
double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
double result = ds.Calculate(x, y);

Console.WriteLine($"Результат вычисления = {result:F3}");

Console.ReadLine();