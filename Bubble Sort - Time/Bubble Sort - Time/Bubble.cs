using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort___Time
{
    class Bubble
    {
        public Bubble(int x)
        { 

            //DateTime start;
            //TimeSpan time;

            //start = DateTime.Now;

            int[] array = new int[x];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = rand.Next(100);     
            BSort(array);
            Console.Read();

            //time = DateTime.Now - start;

            //Console.WriteLine(time);
        }

        static void BSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }

        static void Print(int[] array)
        {
            Console.WriteLine("-----------------------------");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(i + " : " + array[i]);
            }
        }
    }
}
