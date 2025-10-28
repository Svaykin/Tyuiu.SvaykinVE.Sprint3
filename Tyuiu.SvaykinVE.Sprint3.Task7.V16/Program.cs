using Tyuiu.SvaykinVE.Sprint3.Task7.V16.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выполнил: Свайкин В. Е. | АСОиУб-25-1";
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* Спринт #3                                                            *");
        Console.WriteLine("* Тема: Операторы составного присваивания                              *");
        Console.WriteLine("* Задание #7                                                           *");
        Console.WriteLine("* Вариант #16                                                          *");
        Console.WriteLine("* Выполнил Свайкин Владислав Евгеньевич | АСОиУб-25-1                  *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                             *");
        Console.WriteLine("* Напишите программу, которая выводит таблицу значений функции         *");
        Console.WriteLine("*                                                                      *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
        Console.WriteLine("* Функция                                                              *");
        Console.WriteLine("*                                                                      *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");

        double[] Res = ds.GetMassFunction(-5, 5);

        Console.WriteLine("Таблица значений функции:");
        for (int i = -5; i <= 5; i++)
        {
            Console.WriteLine($"f({i}) = {Res[i + 5]}");
        }
        Console.WriteLine("************************************************************************");
        Console.ReadLine();
    }
}