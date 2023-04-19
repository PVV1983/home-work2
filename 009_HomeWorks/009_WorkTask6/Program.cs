/*Використовуючи Visual Studio, створіть проект за шаблоном ConsoleApplication. 
 * Створіть масив розмірністю 10 елементів, виведіть на екран усі елементи масиву у зворотному порядку. 
 */
using System;
using System.Diagnostics;
using System.Text;

namespace _009_WorkTask6
{
    class Program
    {
        static void MyReverse(int[] array)
        {
            int temp = 0;
            int j = array.Length - 1;


            for (int i = 0; i <= j; i++, j--)
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]},");
            }

        }

        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Random rand = new Random();
            int N = 10;

            int[] myArray = new int[N];

            Console.WriteLine("первинний масив");
            // Заповнення масиву.
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = rand.Next(1000);

                Console.WriteLine($"{myArray[i]},");

            }   
            Console.WriteLine("реверсний масив");
            MyReverse(myArray);
        
            
            Console.ReadKey();
        }
    }
}