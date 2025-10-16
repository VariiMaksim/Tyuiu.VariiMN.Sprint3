using Tyuiu.VariiMN .Sprint3.Task0.V2.Lib;


namespace Tyuiu.VariiMN.Sprint3.Task0.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Варий М. Н. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #3                                                              *");
            Console.WriteLine("* Тема: цикл for                                                         *");
            Console.WriteLine("* Задание #0                                                             *");
            Console.WriteLine("* Вариант #2                                                             *");
            Console.WriteLine("* Выполнил: Варий Максим Николаевич. | ИСПб-25-1                         *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу используя цикл for,                                 *");
            Console.WriteLine("* которая вычисляет произведение ряда по формуле                         *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");




            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            int startValue = 1;
            int stopValue = 9;

            Console.WriteLine("Старт = " + startValue);
            Console.WriteLine("Конец = " + stopValue);


            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Сумма ряда = " + ds.GetMultiplySeries(startValue, stopValue));

        }
    }
}