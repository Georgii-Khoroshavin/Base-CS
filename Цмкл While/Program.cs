using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Цикл_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             *  Цикл While
             *  
             *  while (<условие>)
             *  {
             *      <операторы>
             *  }
             *  
             *  Важно: Хотя бы одна переменная в условии должна меняться, иначе цикл может не закончиться.
             */
            int i = 0;
            while (i < 10)
            {
                Console.Write($"{i} ");
                i++;
            }

            Console.ReadKey();
        }
    }
}
