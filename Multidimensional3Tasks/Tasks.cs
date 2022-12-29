using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidimensional3Tasks
{
    public static class Tasks
    {
        public static double Task1(int[,] array, int a)
        {
            double average = 0;
            double sum = 0;
            int count = 0; 

            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {
                   
                    if (array[i, j] < a)

                    {
                        
                        sum += array[i, j];
                        count++;

                    }
                    average = sum / count;
                }

            }

            return average;
        }

        public static int Task2(int[,] array)
        {
            int amount = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (j < i && array[i, j] < 0)
                    {
                        amount++;
                    }

                }
            }

            return amount;
        }

        public static int[] Task3(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            int[] minarray = new int[rows];

            for (int i = 0; i < array.GetLength(0); i++)

            {
                double average = 0;
                double sum = 0;
                int product = 1;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }
                average = sum / rows;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > average)
                    {
                        product *= array[i, j];
                    }
                    minarray[i] = product;
                }

            }

                return minarray;
        }
    }
}
