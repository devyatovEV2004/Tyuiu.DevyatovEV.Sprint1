using Tyuiu.DevyatovEV.Sprint1.Task6.V13.Lib;

Console.Title = "Спринт #1 | Выполнил: Девятов Егор | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #13                                                             *");
Console.WriteLine("* Выполнил: Девятов Егор | ИСТНб-25-1                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу: пользователь вводит текст. Проверить, что буквы     *");
Console.WriteLine("* строки упорядочены по алфавиту.                                         *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.Write("Введите текст: ");
string value = Console.ReadLine();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
bool result = ds.CheckWordsAlphabet(value);

if (result)
{
    Console.WriteLine("Буквы в строке упорядочены по алфавиту");
}
else
{
    Console.WriteLine("Буквы в строке НЕ упорядочены по алфавиту");
}

Console.ReadLine();