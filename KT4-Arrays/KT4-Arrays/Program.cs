using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT4_Arrays
{
    internal class Program
    {
        private int _arrayLenght;
        private int[] _task1Array;

        static void Main(string[] args)
        {

            void Spliter()
            {
                Console.WriteLine();
            }

            void InputException()
            {
                Console.WriteLine("Вы ввели неверные данные");
            }


            void Task1FillArrayRoutine()
            {
                //Task1ArrayLenghtInput();

                Task1ArrayFillInput();

                
            }

            int Task1ArrayLenghtInput()
            {
                Console.WriteLine("Введите длинну массива");

                if (!int.TryParse(Console.ReadLine(), out int arrayLenght))
                {
                    InputException();
                }

                return arrayLenght;
            }

            void Task1ArrayFillInput()
            {
                int[] task1Array = new int[Task1ArrayLenghtInput()];

                foreach (var item in task1Array)
                {
                    Console.WriteLine("Введите число для индекса: " + item);

                    if(!int.TryParse(Console.ReadLine(), out int fillNumber))
                    {
                        InputException();
                    }

                    task1Array[item] = fillNumber;
                }
            }

            void Task1FillArrayComplete()
            {
                Console.WriteLine("Задание 1");

                Spliter();

                Console.WriteLine("Программа просит ввести длинну массива, а после заполнить его, после заполнения - выводит");

                Spliter();

                Task1FillArrayRoutine();
            }

            Task1FillArrayComplete();
        }
    }
}
