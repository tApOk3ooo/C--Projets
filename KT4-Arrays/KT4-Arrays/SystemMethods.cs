using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KT4_Arrays
{
    internal class SystemMethods
    {
        public void Spliter()
        {
            Console.WriteLine();
        }

        public void InputException()
        {
            Spliter();

            Console.WriteLine("Вы ввели неверные данные, попробуйте ещё раз");

            Spliter();
        }

    }
}
