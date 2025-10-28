using Tyuiu.SvaykinVE.Sprint3.Task4.V27.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выполнил: Свайкин В. Е. | АСОиУб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Использование операторов continue и break в циклах                *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #27                                                             *");
        Console.WriteLine("* Выполнил: Свайкин Владислав Евгеньевич | АСОиУб-25-1                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение     *");
        Console.WriteLine("* функции y=x/(cos(x)+sin(x))                                             *");
        Console.WriteLine("* При х = 0 пропустить значение. Полученные значения суммировать.         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int a, b;

        do
        {
            Console.WriteLine("Введите начальное значение x:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите конечное значение x:");
            b = Convert.ToInt32(Console.ReadLine());

            if (a > b) Console.WriteLine("Начальное значение не может быть больше конечного, попробуйте ещё раз.");
        } while (a > b);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(ds.Calculate(a, b));
        Console.ReadKey();
    }
}