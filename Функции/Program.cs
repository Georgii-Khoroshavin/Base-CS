using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Функции
{
    internal class Program
    {
        // void - не возвращает никакого значения
        static void PrintSequence(int a, int b)
        {
            for (int i = a; i < b; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        static int SumSequence(int a, int b)
        {
            int sum = 0;
            for (int i = a; i < b; i++)
            {
                sum += i;
            }
            // return - оператор завершающий выполонение функции и возвращающий значение из неё.
            return sum;
        }

        static void Main(string[] args)
        {
            /*
             *  Функции
             *  Выделенная часть кода, которую можно вызывать по имени и которая
             *  выполняет определённое действие.
             *  
             *  Смысл функций:
             *  1. Хорошая структура кода (понятность кода).
             *  2. Устранение повторяемых частей кода.
             *  
             *  <тип результата> <имя функции>(<параметры функции>...)
             *  {
             *      [return <значение>];
             *  }
             */

            PrintSequence(12, 45);
            Console.WriteLine($"Сумма последовательности = {SumSequence(12, 45)}");
            Console.ReadKey();
        }
    }
}
