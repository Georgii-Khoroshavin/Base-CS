using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Оператор_выбора_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вывести название месяца по его номеру (1 - Январь, 2 - Февраль ...)
            Console.Write("Введите номер месяца: ");
            int month = int.Parse(Console.ReadLine());
            // В switch передаётся какая-то переменная,
            // которую проверяем на соответствие определённым значениям
            switch (month)
            {
                case 1:
                    Console.WriteLine("Январь");
                    break;
                case 2:
                    Console.WriteLine("Февраль");
                    break;
                case 3:
                    Console.WriteLine("Март");
                    break;
                case 4:
                    Console.WriteLine("Апрель");
                    break;
                case 5:
                    Console.WriteLine("Май");
                    break;
                case 6:
                    Console.WriteLine("Июнь");
                    break;
                // Если ни одно значени не совпало
                default:
                    Console.WriteLine("Введены неверные данные!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
