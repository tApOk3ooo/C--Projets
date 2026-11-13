using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT4_Arrays
{
    internal class Task4SumCalculator : SystemMethods
    {
        private const string SumCommand = "sum";
        private const string ExitCommand = "exit";

        private void Routine()
        {
            int[] userArray = Create();
            bool isRunning = true;

            while (isRunning)
            {
                int inputValue = ValueInput();
                userArray = AddValue(userArray, inputValue);

                string command = CommandInput();

                if (command == SumCommand)
                {
                    int arraySum = CalculateSum(userArray);
                    Output(arraySum);
                }
                else if (command == ExitCommand)
                {
                    isRunning = false;
                }
            }
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
            Console.WriteLine($"Введите команду ({SumCommand} / {ExitCommand}) или нажмите Enter, чтобы продолжить:");

            string commandInput = Console.ReadLine();

            Spliter();

            return commandInput;
        }

        private int CalculateSum(int[] userArray)
        {
            int arraySum = 0;

            foreach (var item in userArray)
            {
                arraySum += item;
            }

            return arraySum;
        }

        private void Output(int arraySum)
        {
            Spliter();

            Console.WriteLine("Сумма всех введенных чисел: " + arraySum);

            Spliter();
        }

        public void Task4Complete()
        {
            Console.WriteLine("Задание 4");

            Spliter();

            Console.WriteLine("Пользователь вводит числа, и программа их запоминает" +
                "\nПри вводе команды sum, программа выведет сумму всех введенных чисел" +
                "\nПри вводе команды exit, программа завершается");

            Spliter();

            Routine();

            Spliter();
        }
    }
}