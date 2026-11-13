using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT4_Arrays
{
    internal class Task2FillArrayFromUserInput : SystemMethods
    {
        private void Routine()
        {
            int arrayLength = LengthInput();
            int[] userArray = Create(arrayLength);
            Fill(userArray);
            Print(userArray);
        }

        private int LengthInput()
        {
            Console.WriteLine("Введите длинну массива:");

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

        private int[] Fill(int[] userArray)
        {
            for (int i = 0; i < userArray.Length; i++)
            {
                userArray[i] = i;
            }

            return userArray;
        }

        private void Print(int[] userArray)
        {
            for (int i = 0; i < userArray.Length; i++)
            {
                Console.WriteLine(userArray[i]);
            }
        }

        public void Task2Complete()
        {
            Console.WriteLine("Задание 2");

            Spliter();

            Console.WriteLine("Программа просит пользователя ввести число, после создаёт массив и заполняет его от 0 до введённого числа");

            Spliter();

            Routine();

            Spliter();
        }
    }
}
