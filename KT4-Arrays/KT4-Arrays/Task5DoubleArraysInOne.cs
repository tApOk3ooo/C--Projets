using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT4_Arrays
{
    internal class Task5DoubleArraysInOne : SystemMethods
    {
        private const string NextCommand = "next";

        private void Routine()
        {
            int[] firstArray = FillArray("первого");
            int[] secondArray = FillArray("второго");

            int[] combinedArray = MergeArrays(firstArray, secondArray);

            Output(combinedArray);
        }

        private int[] FillArray(string arrayOrderName)
        {
            Console.WriteLine($"Заполнение {arrayOrderName} массива:");

            Spliter();

            int[] userArray = Create();
            bool isFilling = true;

            while (isFilling)
            {
                int inputValue = ValueInput();
                userArray = AddValue(userArray, inputValue);

                string command = CommandInput();

                if (command == NextCommand)
                {
                    isFilling = false;
                }
            }

            return userArray;
        }

        private int[] Create()
        {
            int[] userArray = new int[0];

            return userArray;
        }

        private int ValueInput()
        {
            Console.WriteLine("Введите значение:");

            int inputValue;
            while (!int.TryParse(Console.ReadLine(), out inputValue))
            {
                InputException();
            }

            Spliter();

            return inputValue;
        }

        private int[] AddValue(int[] userArray, int inputValue)
        {
            int[] newArray = new int[userArray.Length + 1];

            for (int i = 0; i < userArray.Length; i++)
            {
                newArray[i] = userArray[i];
            }

            newArray[newArray.Length - 1] = inputValue;

            return newArray;
        }

        private string CommandInput()
        {
            Console.WriteLine($"Введите команду ({NextCommand}) для завершения ввода массива или нажмите Enter, чтобы продолжить:");

            string commandInput = Console.ReadLine()?.Trim().ToLower() ?? string.Empty;

            Spliter();

            return commandInput;
        }

        private int[] MergeArrays(int[] firstArray, int[] secondArray)
        {
            int[] mergedArray = new int[firstArray.Length + secondArray.Length];

            for (int i = 0; i < firstArray.Length; i++)
            {
                mergedArray[i] = firstArray[i];
            }

            for (int i = 0; i < secondArray.Length; i++)
            {
                mergedArray[firstArray.Length + i] = secondArray[i];
            }

            return mergedArray;
        }

        private void Output(int[] userArray)
        {
            Spliter();

            Console.WriteLine("Объединенный массив:");

            for (int i = 0; i < userArray.Length; i++)
            {
                Console.WriteLine($"Значение под индексом [{i}]: {userArray[i]}");
            }

            Spliter();
        }

        public void Task5Complete()
        {
            Console.WriteLine("Задание 5");

            Spliter();

            Console.WriteLine("Пользователь заполняет два массива чисел, а программа объединяет их в один" +
                "\nПри вводе команды next завершается ввод текущего массива");

            Spliter();

            Routine();

            Spliter();
        }
    }
}