using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Цикл_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // for ([Создание переменной счётчика];[Условие выполнения цикла];[Изменение переменной счётчика])
            // Все разделы необязательны
            // ++ - инкремент (увеличение на 1)
            // -- - декремент (уменьшение на 1)
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i} ");
            }
            Console.ReadKey();
        }
    }
}
