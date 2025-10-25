using Tyuiu.SvaykinVE.Sprint3.Task0.V20.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3| Выполнил:  Свайкин В.Е.| АСОиУб-25-1";
        Console.WriteLine("********************************************************************************");
        Console.WriteLine("* Спринт #3                                                                    *");
        Console.WriteLine("* Тема: Оператор цикла for                                                     *");
        Console.WriteLine("* Задание #0                                                                   *");
        Console.WriteLine("* Вариант #20                                                                  *");
        Console.WriteLine("* Выполнил: Свайкин Владислав Евгеньевич | АСОиУб-25-1                         *");
        Console.WriteLine("********************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                     *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,      *");
        Console.WriteLine("* вычисляет, и печатает результат на экране                                    *");
        Console.WriteLine("*                                                                              *");
        Console.WriteLine("********************************************************************************");
        Console.WriteLine("********************************************************************************");
        Console.WriteLine("* Исходные данные                                                              *");
        Console.WriteLine("********************************************************************************");
        int x = 1;
        int start = 1;
        int stop = 14;
        Console.WriteLine("Переменная x = " + x);
        Console.WriteLine("Старт шага = " + start);
        Console.WriteLine("Конец шага = " + stop);
        Console.WriteLine("********************************************************************************");
        Console.WriteLine("* Результат:                                                                   *");
        Console.WriteLine("********************************************************************************");
        Console.WriteLine("Произведение ряда = " + ds.GetMultiplySeries(x, start, stop));
        Console.ReadKey();

    }
}