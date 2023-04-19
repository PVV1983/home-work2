/*Використовуючи Visual Studio, створіть проект за шаблоном ConsoleApplication. 
 * Створити масив розміру N елементів, заповнити його довільними цілими значеннями (розмір масиву задає користувач). 
 * Вивести на екран: найбільше значення масиву, найменше значення масиву, 
 * загальну суму всіх елементів, середнє арифметичне всіх елементів, 
 * вивести усі непарні значення. 
 * */
using System;
using System.Diagnostics;
using System.Text;

namespace _009_WorkTask2
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("прошу ввести кількість елементів масиву");
            string inputLengthArray = Console.ReadLine();

            Random rand = new Random();

            inputLengthArray = (uint.TryParse(inputLengthArray, out uint N)) ? inputLengthArray : null;

            if (inputLengthArray != null)
            {
                int[] array = new int[N];

                // Заповнення масиву.
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rand.Next(1000);

                    //Console.WriteLine(array[i]);

                }
                Console.WriteLine($"Найбільше значення масиву={array.Max()}");
                Console.WriteLine($"Найменше значення масиву={array.Min()}");
                Console.WriteLine($"Загальна сума всіх елементів={array.Sum()}");
                Console.WriteLine($"Cереднє арифметичне всіх елементів={array.Average()}");
                Console.WriteLine("Усі непарні значення масиву:");
                for (int i = 0; i < array.Length; i++)
                {
                    if ((array[i] % 2) != 0)
                    {
                        Console.WriteLine($"{array[i]}");
                    }

                }

            }
            else
                Console.WriteLine("Кількість елементів масиву введено некоректно, має бути ціле позитивне число");


            
            Console.ReadKey();
        }
    }
}