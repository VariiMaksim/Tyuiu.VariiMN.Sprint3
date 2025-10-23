using Tyuiu.VariiMN.Sprint3.Task7.V30.Lib;


namespace Tyuiu.VariiMN.Sprint3.Task7.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Варий М. Н. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #3                                                              *");
            Console.WriteLine("* Тема: Обработка целочисленной информации                               *");
            Console.WriteLine("* Задание #7                                                             *");
            Console.WriteLine("* Вариант #30                                                            *");
            Console.WriteLine("* Выполнил: Варий Максим Николаевич. | ИСПб-25-1                         *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");




            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            int startValue = -5;
            int stopValue = 5;


            Console.WriteLine("Начало отрезка: " + startValue);
            Console.WriteLine("Конец отрезка: " + stopValue);

            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueArray;
            valueArray = new double[len];

            valueArray = ds.GetMassFunction(startValue, stopValue);




            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("+------+--------+");
            Console.WriteLine("|  x   |  f(x)  |");
            Console.WriteLine("+------+--------+");
            for (int i = 0; i < len; i++)
            {
                int x = startValue + i;
                Console.WriteLine($"| {x,3}  | {valueArray[i],6:F2} |");
            }
            Console.WriteLine("+------+--------+");
            Console.ReadKey();

        }
    }
}