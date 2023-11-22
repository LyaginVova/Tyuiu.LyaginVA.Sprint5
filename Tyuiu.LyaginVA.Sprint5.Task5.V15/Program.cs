using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.LyaginVA.Sprint5.Task5.V15.Lib;

namespace Tyuiu.LyaginVA.Sprint5.Task5.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Лягин В. А. | АСОиУБ-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                     *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Лягин Владимир Александрович | АСОиУБ-23-2                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:|DataSprint5|InPutDataFileTask5V15.txt (файл взять из архива *");
            Console.WriteLine("* согласно вашему варианту. Создать папку в ручную С:|DataSprint5| и      *");
            Console.WriteLine("* скопировать в неё файл) в котором есть набор значение. Найти            *");
            Console.WriteLine("* минимальное вещественное число в файле, которое делится на 5.           *");
            Console.WriteLine("* Полученный результат вывести на консоль. У вещественных значений        *");
            Console.WriteLine("* округлить до трёх знаков после запятой.                                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");
            string path = @"C:\DataSprint5\InPutDataFileTask5V15.txt";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = ds.LoadFromDataFile(path);

            Console.WriteLine("Минимальное вещественное число в файле, которое делится на 5 = " + res);
            Console.ReadKey();
        }
    }
}
