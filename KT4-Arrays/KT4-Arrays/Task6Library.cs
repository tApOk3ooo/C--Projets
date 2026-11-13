using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT4_Arrays
{
    internal class Task6LibrarySearch : SystemMethods
    {
        private void Routine()
        {
            string[] libraryBooks = CreateLibrary();
            string bookQuery = BookTitleInput();
            bool isFound = SearchBook(libraryBooks, bookQuery);
            Output(isFound, bookQuery);
        }

        private string[] CreateLibrary()
        {
            string[] books =
            {
                "Война и мир",
                "Преступление и нажатие",
                "Мастер и Маргарита",
                "Евгений Онегин",
                "Собачье сердце",
                "Три товарища",
                "1984"
            };

            return books;
        }

        private string BookTitleInput()
        {
            Console.WriteLine("Введите название книги для поиска:");

            string input = Console.ReadLine();

            while (input == "")
            {
                InputException();
                input = Console.ReadLine();
            }

            Spliter();

            return input;
        }

        private bool SearchBook(string[] libraryBooks, string bookQuery)
        {
            foreach (string book in libraryBooks)
            {
                if (book.ToLower() == bookQuery.ToLower())
                {
                    return true;
                }
            }

            return false;
        }

        private void Output(bool isFound, string bookQuery)
        {
            Spliter();

            if (isFound)
            {
                Console.WriteLine($"Книга \"{bookQuery}\" есть в библиотеке.");
            }
            else
            {
                Console.WriteLine($"Книги \"{bookQuery}\" нет в библиотеке.");
            }

            Spliter();
        }

        public void Task6Complete()
        {
            Console.WriteLine("Задание 6");

            Spliter();

            Console.WriteLine("Поиск книги в библиотеке без учета регистра");

            Spliter();

            Routine();

            Spliter();
        }
    }
}