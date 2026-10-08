using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT3_Cycles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void Spliter()
            {
                Console.WriteLine();
            }

            void InputException()
            {
                Spliter();

                Console.WriteLine("Не верный ввод, перезапустите программу!");
            }

            void Task1PasswordGenerate()
            {
                const string Uppers = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                const string Lowercase = "abcdefghijklmnopqrstuvwxyz";
                const string Digits = "0123456789";
                const string AllChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_-+=/.,<>|[]{}?';:";


                Console.WriteLine("Введите длинну пароля:");

                string task1PasswordLenghtRaw = Console.ReadLine();

                if (int.TryParse(task1PasswordLenghtRaw, out int task1PasswordLenghtCorrect))
                {
                }
                else
                {
                    InputException();
                }

                Spliter();

                if (task1PasswordLenghtCorrect < 3)
                {
                    Console.WriteLine("Пароль должен содержать минимум 3 символа");
                }
                else
                {
                    Console.WriteLine("Ваш пароль:");

                    Random random = new Random();

                    StringBuilder stringBuilder = new StringBuilder();

                    stringBuilder.Append(Uppers[random.Next(Uppers.Length)]);
                    stringBuilder.Append(Lowercase[random.Next(Lowercase.Length)]);
                    stringBuilder.Append(Digits[random.Next(Digits.Length)]);

                    while (stringBuilder.Length < task1PasswordLenghtCorrect)
                    {
                        stringBuilder.Append(AllChars[random.Next(AllChars.Length)]);
                    }

                    // может сделать перемешивание обязательных с остальными..

                    Console.WriteLine(stringBuilder.ToString());
                }
            }

            void Task1Complete()
            {
                Console.WriteLine("Задание 1");

                Spliter();

                Console.WriteLine("Генератор паролей");

                Spliter();

                Task1PasswordGenerate();

                Spliter();
            }

            void Task2TryGuess()
            {
                Random random = new Random();

                int chosenNumber = random.Next(0, 100 + 1);

                Console.WriteLine("Число от 1 до 100 загадано!");

                Spliter();

                Console.WriteLine("Введите то число, о котором вы думайте:");

                bool isNotCorrect = true;

                while (isNotCorrect)
                {
                    string task2GuessInputValueRaw = Console.ReadLine();

                    if (!int.TryParse(task2GuessInputValueRaw, out int task2GuessInputValueCorrect))    // как я раньше не догадался
                    {
                        InputException();
                        Spliter();
                        continue;
                    }

                    Spliter();

                    if (task2GuessInputValueCorrect < chosenNumber)
                    {
                        Console.WriteLine("Число больше");

                    }
                    else if (task2GuessInputValueCorrect > chosenNumber)
                    {
                        Console.WriteLine("Число меньше");

                    }
                    else
                    {
                        Console.WriteLine("Вы угадали!");
                        isNotCorrect = false;
                    }
                }
            }

            void Task2Complete()
            {
                Console.WriteLine("Задание 2");

                Spliter();

                Console.WriteLine("Игра - Угадай число");

                Spliter();

                Task2TryGuess();

                Spliter();
            }

            void Task3HypothesisProof()
            {
                Console.WriteLine("Введите первую цифру, с которой начинается дипаозон чисел");

                string task3FirstValueOfRangeRaw = Console.ReadLine();

                if (!int.TryParse(task3FirstValueOfRangeRaw, out int task3FirstValueOfRangeCorrect))
                {
                    InputException();
                }

                Spliter();

                Console.WriteLine("Введите вторую цифру, до которой задаётся дипаозон чисел");

                string task3SecondValueOfRangeRaw = Console.ReadLine();

                if (!int.TryParse(task3SecondValueOfRangeRaw, out int task3SecondValueOfRangeCorrect))
                {
                    InputException();
                }

                for (int i = task3FirstValueOfRangeCorrect; i < task3SecondValueOfRangeCorrect; i++)
                {
                }

            }

            void Task3Complete()
            {
                Console.WriteLine("Задание 3");

                Spliter();

                Console.WriteLine("Доказательство гипотезы Сиракуз");

                Spliter();

                Task3HypothesisProof();

                Spliter();
            }

            void Task4Complete()
            {
                Console.WriteLine("");

                Spliter();

                Console.WriteLine();
            }

            //Task1Complete();
            //Task2Complete();
            Task3Complete();
        }
    }
}
