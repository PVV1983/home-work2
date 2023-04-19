/*Використовуючи Visual Studio, створіть проект за шаблоном ConsoleApplication. Потрібно:
 * 1) Створити метод MyReverse(int [ ] array), який приймає як аргумент масив цілих чисел і повертає інвертований масив 
 * (елементи масиву у зворотному порядку).
 * 2) Створіть метод int [] SubArray (int [] array, int index, int count). 
 * Метод повертає частину отриманого як аргумент масиву, починаючи з позиції зазначеної в аргументі index, розмірністю, 
 * яка відповідає значенню аргументу count. Якщо аргумент count містить значення більше, ніж кількість елементів, 
 * які входять до частини вихідного масиву (від зазначеного індексу index, до індексу останнього елемента), 
 * то при формуванні нового масиву розмірністю в count, заповніть одиницями ті елементи, які не були 
 * скопійовані з вихідного масиву.  
 * */
using System;
using System.Diagnostics;
using System.Text;

namespace _009_WorkTask3
{
    class Program
    {
        static int [] MyReverse(int[] array)
        {
            int temp = 0;
            int j = array.Length - 1;


            for (int i = 0; i <= j; i++, j--)
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
            return array ;

        }

        static int[] SubArray(int[] array, int index, int count)
        {
            int[] subArray = new int[count];
            
            for (int i = 0; i < subArray.Length; i++)
            {
                if (array.Length > index)
                    subArray[i] = array[index++];
                else subArray[i] = 1;
            }
           return subArray;

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

                myArray = MyReverse(myArray);
                Console.WriteLine("реверсний масив");
                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.Write($"{myArray[i]},");
                }
                Console.Write("\n");
                Console.WriteLine("фрагмент масиву");
                myArray = SubArray(myArray,4,10);
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