using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Условные_конструкции
{
    internal class Program
    {
        // Условные конструкции (if)
        static void Main(string[] args)
        {
            int num = 15;

            // if (<условное выражение, возращающее true или false>)
            // else - не обязательный, означает обратное значение условию,
            // которое записано в if

            // Операторы, которые возврают true или false:
            // >  <  ==  !=  >=  <=

            // Также, переменные логического типа (bool) тоже хранят только true или false

            // Логические выражения могут объедиться при помощи логических
            // операций: && - И, || - ИЛИ, ! - НЕ
            // && - истино, если все операторы выражения истины
            // || - истино, если хотя бы один оператор выражения истинен
            // !  - изменяет true на false и наоборот
            if (num % 2 == 0)
            {
                Console.WriteLine("Число чётное");
            }
            else
            {
                Console.WriteLine("Число нечётное");
            }
        }
    }
}
