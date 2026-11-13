using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT4_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1FillArray task1 = new Task1FillArray();
            Task2FillArrayFromUserInput task2 = new Task2FillArrayFromUserInput();
            Task3RandomInputArray task3 = new Task3RandomInputArray();
            Task4SumCalculator task4 = new Task4SumCalculator();
            Task5DoubleArraysInOne task5 = new Task5DoubleArraysInOne();
            Task6LibrarySearch task6 = new Task6LibrarySearch();

            task1.Task1Complete();
            task2.Task2Complete();
            task3.Task3Complete();
            task4.Task4Complete();
            task5.Task5Complete();
            task6.Task6Complete();
        }
    }
}