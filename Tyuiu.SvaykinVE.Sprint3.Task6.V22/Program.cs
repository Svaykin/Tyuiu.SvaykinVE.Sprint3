using Tyuiu.SvaykinVE.Sprint3.Task6.V22.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнила: Свайкин В. Е. | АСОиУб-25-1";
        Console.WriteLine("*************************************************************************");
        Console.WriteLine("* Спринт #3                                                             *");
        Console.WriteLine("* Тема: Обработка целочисленной информации                              *");
        Console.WriteLine("* Задание #6                                                            *");
        Console.WriteLine("* Вариант #22                                                           *");
        Console.WriteLine("* Выполнила: Свайкин Владислав Евгеньевич | АСОиУб-25-1                 *");
        Console.WriteLine("*************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                              *");
        Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих     *");
        Console.WriteLine("* числовому отрезку [19, 31] количество всех делителей                  *");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                      *");
        Console.WriteLine("*************************************************************************");
        int startValue = 19;
        int stopValue = 31;
        Console.WriteLine("Старт шага первой суммы ряда = " + startValue);
        Console.WriteLine("Конец шага первой суммы ряда =  " + stopValue);



        Console.WriteLine("*************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
        Console.WriteLine("*************************************************************************");
        Console.WriteLine("Сумма ряда = " + ds.GetSumTheDivisors(startValue, stopValue));
        Console.ReadKey();
    }
}