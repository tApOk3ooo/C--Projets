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

                int result;

                if (task3FirstValueOfRangeCorrect != 0 && task3SecondValueOfRangeCorrect != 0 &&
                    task3FirstValueOfRangeCorrect != 1 && task3SecondValueOfRangeCorrect != 1)
                {
                    for (int i = task3FirstValueOfRangeCorrect; i < task3SecondValueOfRangeCorrect; i++)
                    {
                        bool isNotProve = true;

                        int currentNumber = i;

                        while (isNotProve)
                        {
                            if (currentNumber % 2 == 0)
                            {
                                result = currentNumber / 2;

                                Spliter();

                                Console.WriteLine($"{currentNumber} / 2 = {result}");

                                if (result <= 1)
                                {
                                    isNotProve = false;

                                    Spliter();
                                }
                                else
                                {
                                    currentNumber = result;
                                }
                            }
                            else if (currentNumber % 2 == 1)
                            {
                                result = ((currentNumber * 3) + 1) / 2;
                                Spliter();
                                Console.WriteLine($"{currentNumber} * 3 + 1 / 2 = {result}");

                                if (result <= 1)
                                {
                                    isNotProve = false;

                                    Spliter();
                                }
                                else
                                {
                                    currentNumber = result;
                                }
                            }
                        }
                    }
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

            void Task4SerachAllPerfectNumbers()
            {
                for (int currentNumber = 2; currentNumber < 10000; currentNumber++)
                {
                    int sum = 0;

                    for (int i = 1; i <= currentNumber / 2; i++)
                    {
                        if (currentNumber % i == 0)
                        {
                            sum += i;
                        }
                    }

                    if (sum == currentNumber)
                    {
                        Console.WriteLine($"{currentNumber} - это совершенное число");
                    }
                }
            }

            void Task4Complete()
            {
                Console.WriteLine("Задание 4");

                Spliter();

                Console.WriteLine("Находит все совершенные числа в диапозоне от 1 до 10000");

                Spliter();

                Task4SerachAllPerfectNumbers();

                Spliter();
            }

            void Task5quareConstruct()
            {
                char startAndEndSymbol = '-';
                char strokeSymbol = '|';
                char squareSymbol = '0';

                int squareLines = 8;

                int squareColumn = 18;

                int width = 20;

                StringBuilder stringBuilder = new StringBuilder();

                stringBuilder.Append(startAndEndSymbol, width);

                string startAndEndString = stringBuilder.ToString();

                Console.WriteLine(startAndEndString);

                stringBuilder.Clear();

                stringBuilder.Append(squareSymbol, squareColumn);

                stringBuilder.Insert(0, strokeSymbol);

                stringBuilder.Append(strokeSymbol);

                string squreString = stringBuilder.ToString();

                Spliter();

                for (int i = 0; i < squareLines; i++)
                {
                    Console.WriteLine(squreString);

                    Spliter();
                }

                stringBuilder.Clear();

                stringBuilder.Append(startAndEndSymbol, width);

                Console.WriteLine(startAndEndString);
            }

            void Task5Complete()
            {
                Console.WriteLine("Задание 5");

                Spliter();

                Console.WriteLine("Вывод на экран прямоуголника из символов");

                Spliter();

                Task5quareConstruct();
            }

            void Task6ChristmasTree()
            {
                Console.WriteLine("Введите число до которого будет строиться ёлочка:");

                string treeValueRaw = Console.ReadLine();

                if (!int.TryParse(treeValueRaw, out int treeValueCorrect))
                {
                    InputException();
                }

                Spliter();

                int currentNumber = 1;
                int lineLenght = 1;

                while (currentNumber <= treeValueCorrect)
                {
                    for (int i = 0; i < lineLenght && currentNumber <= treeValueCorrect; i++)
                    {
                            Console.Write(currentNumber + " ");
                            currentNumber++;
                    }

                    Console.WriteLine();
                    lineLenght++;
                }
            }

            void Task6Complete()
            {
                Console.WriteLine("Задание 6");

                Spliter();

                Console.WriteLine("Выдаёт арт ёлочки из цифр от 1 до числа пользователя");

                Spliter();

                Task6ChristmasTree();
            }

            void Task7Vave()
            {
                Console.WriteLine("Введите число до которого будет строиться волна:");

                string vaveValueRaw = Console.ReadLine();

                if (!int.TryParse(vaveValueRaw, out int vaveValueCorrect))
                {
                    InputException();
                }

                Spliter();

                int currentNumber = 1;
                int lineLenght = 1;

                while (currentNumber <= vaveValueCorrect)
                {
                    for (int i = 0; i < lineLenght && currentNumber <= vaveValueCorrect; i++)
                    {
                        Console.Write(currentNumber + " ");
                        currentNumber++;
                    }

                    Console.WriteLine();
                    lineLenght++;
                }
            }

            void Task7Complete()
            {
                Console.WriteLine("Задание 7");

                Spliter();

                Console.WriteLine("Выводит волны от 1 до числа пользователя");

                Spliter();
            }

            //Task1Complete();
            //Task2Complete();
            //Task3Complete();
            //Task4Complete();
            //Task5Complete();
            Task6Complete();


        }
    }
}
