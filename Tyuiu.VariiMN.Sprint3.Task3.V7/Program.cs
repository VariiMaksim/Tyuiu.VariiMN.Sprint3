using Tyuiu.VariiMN.Sprint3.Task3.V7.Lib;


namespace Tyuiu.VariiMN.Sprint3.Task3.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Варий М. Н. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #3                                                              *");
            Console.WriteLine("* Тема: оператор цикла foreach                                           *");
            Console.WriteLine("* Задание #3                                                             *");
            Console.WriteLine("* Вариант #7                                                             *");
            Console.WriteLine("* Выполнил: Варий Максим Николаевич. | ИСПб-25-1                         *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Используя цикл foreach заменить буквы g на                             *");
            Console.WriteLine("* цифру 4 в строке: gft hggt ntg                                         *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");




            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            string value = "gft hggt ntg";
            char iz = 'g';
            char zam = '4';

            Console.WriteLine("Исходная строка: " + value);
            Console.WriteLine("Заменить символ: " + iz);
            Console.WriteLine("На символ: " + zam);


            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Результат = " + ds.ReplaceCharOnNum(value,iz, zam));

        }
    }
}