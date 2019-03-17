using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    public class Program
    {
        public static void Main(string [] args)
        {
          
        }
        public static int Partition(int[] array, int low, int high)
        {
            int marker = low;
            for (int i = low; i <= high; i++)
            {
                if (array[i] <= array[high])
                {
                    int temp = array[marker];
                    array[marker] = array[i];
                    array[i] = temp;
                    marker += 1;
                }
            }
            return marker - 1;
        }
        public static void QuickSort(int[] array, int low, int high)
        {
            //rnd = new Random();
            //rnd.Next(); // возвращает случайное число от 0 до int.MaxValue
            //rnd.Next(0, 5); // возвращает случайное число от 0 до 4 включительно
            if (low >= high)
            {
                return;
            }
            int pivot = Partition(array, low, high);
            QuickSort(array, low, pivot - 1);
            QuickSort(array, pivot + 1, high);
        }
    }
}
