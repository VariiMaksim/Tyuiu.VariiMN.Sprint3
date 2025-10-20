using Tyuiu.VariiMN.Sprint3.Task1.V7.Lib;


namespace Tyuiu.VariiMN.Sprint3.Task1.V7
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
            Console.WriteLine("* Задание #1                                                             *");
            Console.WriteLine("* Вариант #7                                                             *");
            Console.WriteLine("* Выполнил: Варий Максим Николаевич. | ИСПб-25-1                         *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу используя цикл while, которая вычисляет             *");
            Console.WriteLine("* произведение ряда по формуле, при a=0,25                               *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");




            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            double value = 0.25;
            int startValue = 1;
            int stopValue = 9;

            Console.WriteLine("Переменная a = " + value);
            Console.WriteLine("Старт = " + startValue);
            Console.WriteLine("Конец = " + stopValue);


            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Сумма ряда = " + ds.GetMultiplySeries(value, startValue, stopValue));

        }
    }
}