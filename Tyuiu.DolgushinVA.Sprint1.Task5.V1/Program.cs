using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.DolgushinVA.Sprint1.Task5.V1.Lib;
namespace Tyuiu.DolgushinVA.Sprint1.Task5.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Долгушин В. А. | ИИПб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Долгушин Вадим Алексеевич | ИИПб-23-3                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая находит расстояние между двумя точками с    *");
            Console.WriteLine("* заданными координатами (x, y), округляет значение до целого числа       *");
            Console.WriteLine("* и печатает результат на экране.                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x1;
            Console.Write("Введите значение X1: ");
            x1 = Convert.ToDouble(Console.ReadLine());

            double y1;
            Console.Write("Введите значение Y1: ");
            y1 = Convert.ToDouble(Console.ReadLine());

            double x2;
            Console.Write("Введите значение X2: ");
            x2 = Convert.ToDouble(Console.ReadLine());

            double y2;
            Console.Write("Введите значение Y2: ");
            y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Расстояние между двумя точками = " + ds.DistanceBetweenDots(x1, y1, x2, y2));
            Console.ReadLine();
        }
    }
}
