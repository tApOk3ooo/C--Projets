using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT4_Arrays
{
    internal class Task2FillArrayFromUserInput : SystemMethods
    {
        private void Task2Routine()
        {
            int arrayLength = LengthInput();
            int[] userArray = CreateArray(arrayLength);
            int[] filledUserArray = Fill(userArray);
            PrintArray(filledUserArray);
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

        private int[] CreateArray(int arrayLength)
        {
            int[] userArray = new int[arrayLength];

            return userArray;
        }

        private int[] Fill(int[] userArray)
        {
            int[] filledUserArray = new int[userArray.Length];

            for (int i = 0; i < userArray.Length; i++)
            {

                filledUserArray[i] = i;
            }

            return filledUserArray;
        }

        private void PrintArray(int[] filledUserArray)
        {
            for (int i = 0; i < filledUserArray.Length; i++)
            {
                Console.WriteLine(filledUserArray[i]);
            }
        }

        public void Task2Complete()
        {
            Console.WriteLine("Задание 2");

            Spliter();

            Console.WriteLine("Программа просит пользователя ввести число, после создаёт массив и заполняет его от 0 до введённого числа");

            Spliter();

            Task2Routine();

            Spliter();
        }
    }
}
