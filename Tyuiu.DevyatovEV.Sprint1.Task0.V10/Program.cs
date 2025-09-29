using Tyuiu.DevyatovEV.Sprint1.Task0.V10.Lib;
DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнил: Девятов Егор | ИСТНб-25-1";

Console.WriteLine("**************************************************");
Console.WriteLine("* Спринт #1");
Console.WriteLine("* Темв: Базовые навыки работы в C#");
Console.WriteLine("* Вариант #10");
Console.WriteLine("* Задание #0");
Console.WriteLine("Выполнил: Девятов Егор | ИСТНб-25-1");
Console.WriteLine("**************************************************");
Console.WriteLine("* УСЛОВИЕ:");
Console.WriteLine("* Написать программу, которая вычисляет выражение (3/6-4)*3 и печатает результат на экране.");
Console.WriteLine("**************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");
Console.WriteLine("(3/6-4)*3");
Console.WriteLine("**************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:");
Console.WriteLine(ds.Calculate());
Console.ReadLine();