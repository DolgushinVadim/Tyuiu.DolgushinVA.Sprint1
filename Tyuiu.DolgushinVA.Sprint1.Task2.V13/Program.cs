using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.DolgushinVA.Sprint1.Task2.V13.Lib;
namespace Tyuiu.DolgushinVA.Sprint1.Task2.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Долгушин В. А. | ИИПб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Долгушин Вадим Алексеевич | ИИПб-23-3                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя расстояние       *");
            Console.WriteLine("* в милях, выполняет указанные расчёты и печатает расстояние в километрах *");
            Console.WriteLine("* на экране.                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x;
            Console.WriteLine("Введите расстояние в милях:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Расстояние = " + ds.ConvertMilesToKm(x) + " км");
            Console.ReadLine();
        }
    }
}
