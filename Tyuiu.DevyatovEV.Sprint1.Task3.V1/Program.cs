using Tyuiu.DevyatovEV.Sprint1.Task3.V1.Lib;

Console.Title = "Спринт #1 | Выполнил: Девятов Егор | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #1                                                              *");
Console.WriteLine("* Выполнил: Девятов Егор | ИСТНб-25-1                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу вычисления объема цилиндра.                          *");
Console.WriteLine("* Ответ округлить до 3 знаков после запятой.                              *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.Write("Введите радиус основания цилиндра (r): ");
double r = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите высоту цилиндра (h): ");
double h = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
double result = ds.CylinderVolume(r, h);

Console.WriteLine($"Объем цилиндра = {result:F3}");

Console.ReadLine();