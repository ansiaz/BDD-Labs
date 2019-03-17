using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickSort;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTreeElenets()
        {
            int[] array = new int[] { 3, 2, 1 };
            QuickSort.Program.QuickSort(array, 0, 2);
            Assert.IsTrue(array[0] <= array[1] && array[1] <= array[2]);
        }
        [TestMethod]
        public void TestOneHangredElements()
        {
            int[] array = new int[100];
            for(int i = 0; i < array.Length;i++ )
            {
                array[i] = 1;
            }
            QuickSort.Program.QuickSort(array, 0, 99);
        }

        [TestMethod]
        public void Test1000Element()
        {
            int[] array = new int[1000];
            var rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next();
            }
            QuickSort.Program.QuickSort(array, 0, 999);
            for (int i = 0; i < 10; i++)
            {
                var x = rnd.Next(0,array.Length - 1);
                var y = rnd.Next(0,array.Length - 1);
                if (x > y)
                {
                    Assert.IsTrue(array[x] > array[y]);
                }
                else
                if (x < y)
                {
                    Assert.IsTrue(array[x] < array[y]);
                }
                else
                {
                    Assert.IsTrue(array[x] == array[y]);
                }
            }
            
        }

        [TestMethod]
        public void TestEmptyElements()
        {
            int[] array = new int[] { };
            QuickSort.Program.QuickSort(array, 0, 0);
        }
        [TestMethod]
        public void TestMuchElements()
        {
            var rnd = new Random();
            int[] array = new int[150000000];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0,array.Length - 1);
            }
            QuickSort.Program.QuickSort(array, 0, 149999999);
        }
    }
}
