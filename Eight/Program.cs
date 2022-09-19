using System;
namespace Lessons
{
    internal class Program
    {
        static void foo(ref int[] myArray, int value, int index)
        {
            int[] newArray = new int[myArray.Length + 1]; // создание масива с +1 елементом для добавления нового елемента
            newArray[index] = value; // Присвоение индексу число в масиве
            for (int i = 0; i < index; i++) // Копирования масива до нашего вставленого числа в масив
            {
                newArray[i] = myArray[i];
            }
            for (int i = index; i < myArray.Length; i++)// Копирования масива после нашего вставленого числа в масив
            {
                newArray[i + 1] = myArray[i];
            }
            myArray = newArray; // измена ссылки старого масива
        }
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] myArray = new int[6]; // Создание массива
            for (int i = 0; i < myArray.Length; i++) // Заполнение масива
            {
                myArray[i] = random.Next(100);
            }
            Console.Write("Введите елемент масива куда хотите добавить число : ");
            int index = int.Parse(Console.ReadLine()); // Создание и ввод елемента масива
            Console.Write("Введите число которое хотите добавить в массив : ");
            int value = int.Parse(Console.ReadLine());// Создание и ввод числа добавляемого в масив
            foo(ref myArray, value, index); // вызов метода
            for (int i = 0; i < myArray.Length; i++) // вывод масива
            {
                Console.WriteLine(myArray[i]);
            }
            Console.ReadLine();
        }
    }
}