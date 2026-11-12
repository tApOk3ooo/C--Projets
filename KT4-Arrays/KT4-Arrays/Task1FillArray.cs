using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT4_Arrays
{
    internal class Task1FillArray : SystemMethods
    {
        private void Task1Routine()
        {
            int arrayLength= LengthInput();
            int[] userArray = FillInput(arrayLength);
            ArrayOutput(userArray);
        }

        private int LengthInput()
        {
            Console.WriteLine("Введите длинну массива");

            int arrayLength;
            while (!int.TryParse(Console.ReadLine(), out arrayLength) || arrayLength<= 0)
            {
                InputException();
            }

            Spliter();

            return arrayLength;
        }

        private int[] FillInput(int arrayLength)
        {
            int[] _task1Array = new int[arrayLength];

            for (int i = 0; i < _task1Array.Length; i++)
            {
                Console.WriteLine($"Введите число для индекса {i}: ");

                int fillNumber;

                while (!int.TryParse(Console.ReadLine(), out fillNumber))
                {
                    InputException();
                }

                Spliter();

                _task1Array[i] = fillNumber;
            }

            return _task1Array;
        }

        private void ArrayOutput(int[] _task1Array)
        {
            Spliter();

            int _arrayIndex = -1;

            foreach (var item in _task1Array)
            {
                _arrayIndex++;
                Console.WriteLine($"Значение в массиве под индексом [{_arrayIndex}]: " + item);
            }

            Spliter();
        }

        public void Task1Complete()
        {
            Console.WriteLine("Задание 1");

            Spliter();

            Console.WriteLine("Программа просит ввести длинну массива, а после заполнить его, после заполнения - выводит");

            Spliter();

            Task1Routine();

            Spliter();
        }
    }
}
