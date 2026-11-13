using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT4_Arrays
{
    internal class Task3RandomInputArray : SystemMethods
    {
        private void Routine()
        {
            int arrayLength = LengthInput();
            int[] userArray = Create(arrayLength);
            FillInput(userArray);
            Sort(userArray);
            Output(userArray);
        }

        private int LengthInput()
        {
            Console.WriteLine("Введите длинну массива");

            int arrayLength;
            while (!int.TryParse(Console.ReadLine(), out arrayLength) || arrayLength <= 0)
            {
                InputException();
            }

            Spliter();

            return arrayLength;
        }
        private int[] Create(int arrayLength)
        {
            int[] userArray = new int[arrayLength];

            return userArray;
        }

        private int[] FillInput(int[] userArray)
        {
            for (int i = 0; i < userArray.Length; i++)
            {
                Console.WriteLine($"Введите число для индекса {i}: ");

                int fillNumber;

                while (!int.TryParse(Console.ReadLine(), out fillNumber))
                {
                    InputException();
                }

                Spliter();

                userArray[i] = fillNumber;
            }

            return userArray;
        }

        private int[] Sort(int[] userArray)
        {
            Array.Sort(userArray);

            return userArray;
        }

        private void Output(int[] userArray)
        {
            Spliter();

            int arrayIndex = -1;

            foreach (var item in userArray)
            {
                arrayIndex++;
                Console.WriteLine($"Значение в массиве под индексом [{arrayIndex}]: " + item);
            }

            Spliter();
        }

        public void Task3Complete()
        {
            Console.WriteLine("Задание 3");

            Spliter();

            Console.WriteLine("Пользователь вводит длинну массива, заполняет его, а после его сортирует и выводит");

            Spliter();

            Routine();

            Spliter();
        }
    }
}
