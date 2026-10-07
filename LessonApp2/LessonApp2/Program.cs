using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void Splitter()
            {
                Console.WriteLine();
            }

            void InputException()
            {
                Splitter();

                Console.WriteLine("Перезапустите программу и введите целое число!");

                Splitter();

                return;
            }

            void TaskOne()
            {
                Console.WriteLine("Задание один");

                Splitter();

                Console.WriteLine("Введите множитель a, для вывода результата уравнения a^6");

                string taskOneInputRawData = Console.ReadLine();

                if (int.TryParse(taskOneInputRawData, out int taskOneInputCorrectData))
                {
                    int taskOneInputCorrectDataPowX2 = taskOneInputCorrectData * taskOneInputCorrectData;
                    int taskOneInputCorrectDataPowX3 = taskOneInputCorrectDataPowX2 * taskOneInputCorrectData;
                    int taskOneInputCorrectDataPowX6 = taskOneInputCorrectDataPowX3 * taskOneInputCorrectDataPowX3;

                    Splitter();

                    Console.WriteLine($"Значение уравнения с вашими данными: {taskOneInputCorrectDataPowX6}");

                    Splitter();
                }
                else
                {
                    InputException();
                }
            }

            void TaskTwo()
            {
                Console.WriteLine("Задание два");

                Splitter();

                Console.WriteLine("Введите количесвто дней для переовода в часы, минуты и секунды:");

                string taskTwoInputDaysRawData = Console.ReadLine();

                if ( int.TryParse(taskTwoInputDaysRawData, out int taskTwoInputDaysCorrectData))
                {
                    int taskTwoInputDaysConverToHoursData = taskTwoInputDaysCorrectData * 24;
                    int taskTwoInputDaysConverToMinutesData = taskTwoInputDaysCorrectData * 1440;
                    int taskTwoInputDaysConverToSecondsData = taskTwoInputDaysCorrectData * 86400;

                    Splitter();

                    Console.WriteLine("В этом количестве дней:");
                    Console.WriteLine($"Часы: {taskTwoInputDaysConverToHoursData}");
                    Console.WriteLine($"Минуты: {taskTwoInputDaysConverToMinutesData}");
                    Console.WriteLine($"Секунды: {taskTwoInputDaysConverToSecondsData}");

                    Splitter();
                }
                else
                {
                    InputException();
                }
            }

            void TaskThree()
            {
                Console.WriteLine("Задание три");

                Splitter();

                Console.WriteLine("Программа вычисляет площадь прямоугльника по формуле a * b");

                Splitter();

                Console.WriteLine("Введите a:");

                string taskThreeInputARawData = Console.ReadLine();

                if (float.TryParse(taskThreeInputARawData, out float taskThreeInputACorrectData))
                {

                }
                else
                {
                    InputException();
                }

                Splitter();

                Console.WriteLine("Введите b:");

                string taskThreeInputBRawData = Console.ReadLine();

                if(float.TryParse(taskThreeInputBRawData, out float taskThreeInputBCorrectData))
                {

                }
                else
                {
                    InputException();
                }

                Splitter();

                float square = taskThreeInputACorrectData * taskThreeInputBCorrectData;

                Console.WriteLine($"Площадь прямоугльника: {square}");

                Splitter();
            }

            void TaskFour()
            {
                Console.WriteLine("Задание четыре");

                Splitter();

                Console.WriteLine("Программа вычисляет средний возраст Тани и Мити из введённых пользователем данных");

                Splitter();

                Console.WriteLine("Введите возраст Тани:");

                string taskFourInputTanyasAgeRawData = Console.ReadLine();

                if (int.TryParse(taskFourInputTanyasAgeRawData, out int taskFourInputTanyasAgeCorrectData))
                {

                }
                else
                {
                    InputException();
                }

                Splitter();

                Console.WriteLine("Введите возраст Мити:");

                string taskFourInputMityasAgeRawData = Console.ReadLine();

                if (float.TryParse(taskFourInputMityasAgeRawData, out float taskFourInputMityasAgeCorrectData))
                {

                }
                else
                {
                    InputException();
                }

                Splitter();

                float taskFourMiddleAge = (taskFourInputTanyasAgeCorrectData + taskFourInputMityasAgeCorrectData) / 2;

                Console.WriteLine($"Средний возраст: {taskFourMiddleAge}");
            }


            TaskOne();
            TaskTwo();
            TaskThree();
            TaskFour();
        }
    }
}
