/*Використовуючи Visual Studio, створіть проект за шаблоном ConsoleApplication. 
 * Потрібно: Створити метод, який виконуватиме збільшення довжини масиву переданого як аргумент, на 1 елемент. 
 * Елементи масиву повинні зберегти своє значення та порядок індексів. 
 * Створіть метод, який приймає два аргументи, перший аргумент типу int [ ] array, другий аргумент типу int value. 
 * У тілі методу реалізуйте можливість додавання другого аргументу методу до масиву за індексом – 0, 
 * при цьому довжина нового масиву повинна збільшитися на 1 елемент, а елементи одержуваного масиву 
 * як перший аргумент мають скопіюватися в новий масив починаючи з індексу - 1.  
 */
using System;
using System.Diagnostics;
using System.Reflection;
using System.Text;

namespace _009_WorkTask4
{
    class Program
    {
        static int[] AddOneArray(int[] array)
        {
            int []  tempArray = new int[array.Length + 1];
            
            for (int i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i];
            }
            tempArray[tempArray.Length - 1] = 1;

            array = tempArray;

            return array;

        }

        static int[] AddZeroArray(int[] array, int value)
        {
            int[] tempArray = new int[array.Length + 1];
            tempArray[0] = value;

            for (int i = 0; i < array.Length; i++)
            {
                tempArray[i+1] = array[i];
            }
            array = tempArray;
            return array;
        }

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
                int[] myArray = new int[N];
                Console.WriteLine("первинний масив");
                // Заповнення масиву.
                for (int i = 0; i < myArray.Length; i++)
                {
                    myArray[i] = rand.Next(1000);

                    Console.WriteLine($"{myArray[i]},");

                }

                myArray = AddOneArray(myArray);
                Console.WriteLine("масив з доданним елементом в кінці");
                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.Write($"{myArray[i]},");
                }
                Console.Write("\n");
                Console.WriteLine("масив з доданним елементом з початку");
                myArray = AddZeroArray(myArray, 5);
                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.Write($"{myArray[i]},");
                }

            }
            else
                Console.WriteLine("Кількість елементів масиву введено некоректно, має бути ціле позитивне число");

            Console.ReadKey();
        }
    }
}