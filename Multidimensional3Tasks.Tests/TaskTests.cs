using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidimensional3Tasks.Tests
{
    [TestFixture]
    public class TaskTests
    {
        [Test]
        public void Task1_ReturnsCorrectValue()
        {
            int[,] array1 = new int[,] { { 10, 70, 5 },
                                        { 1, 6, 3 },
                                        { 8, 5, -4 } };

            int[,] array2 = new int[,] { { 4, 10, 5 },
                                        { 3, 2, 35 },
                                        { 30, 55, 66 } };

            int[,] array3 = new int[,] { { 5, 8, 10 },
                                        { 90, 55, 11 },
                                        { 4, 40, -10 } };

            int a1 = 4;
            int a2 = 5;
            int a3 = 6;

            double expected1 = 0;
            double expected2 = 3;
            double expected3 = -0.33;

            var actual1 = Tasks.Task1(array1, a1);
            var actual2 = Tasks.Task1(array2, a2);
            var actual3 = Tasks.Task1(array3, a3);

            Assert.AreEqual(expected1, actual1, 0.01, "Task1 returns incorrect value.");
            Assert.AreEqual(expected2, actual2, 0.01, "Task1 returns incorrect value.");
            Assert.AreEqual(expected3, actual3, 0.01, "Task1 returns incorrect value.");
        }

        [Test]
        public void Task2_ReturnsCorrectValue()
        {
            int[,] array1 = new int[,] { { 1, 0, 5 },
                                        { -1, 3, 3 },
                                        { -1, 5 ,6 } };
            int[,] array2 = new int[,] { { 15, 60, 65 },
                                        { -5, 14, 53 },
                                        { -1, -10 ,59 } };
            int[,] array3 = new int[,] { { 15, 10, -35 },
                                        { 14, 352, -32 },
                                        { 15, 43 ,64 } };

            int expected1 = 2;
            int expected2 = 3;
            int expected3 = 0;

            var actual1 = Tasks.Task2(array1);
            var actual2 = Tasks.Task2(array2);
            var actual3 = Tasks.Task2(array3);

            Assert.AreEqual(expected1, actual1, "Task2 returns incorrect value.");
            Assert.AreEqual(expected2, actual2, "Task2 returns incorrect value.");
            Assert.AreEqual(expected3, actual3, "Task2 returns incorrect value.");
        }

        [Test]
        public void Task3_ReturnsCorrectValue()
        {
            int[,] array1 = new int[,] { { 10, 6, 5 },
                                        { 12, 3, 30 },
                                        { 6, 9 ,6 } };
            int[,] array2 = new int[,] { { 15, 20, 5 },
                                        { 15, 3, 9 },
                                        { 12, 35 ,6 } };
            int[,] array3 = new int[,] { { 2, 0, 7 },
                                        { 13, 15, 31 },
                                        { 10, 5 ,0 } };

            int[] expected1 = { 10, 30, 9 };
            int[] expected2 = { 300, 15, 35 };
            int[] expected3 = { 7, 31, 10 };

            var actual1 = Tasks.Task3(array1);
            var actual2 = Tasks.Task3(array2);
            var actual3 = Tasks.Task3(array3);

            Assert.AreEqual(expected1, actual1, "Task3 returns incorrect value.");
            Assert.AreEqual(expected2, actual2, "Task3 returns incorrect value.");
            Assert.AreEqual(expected3, actual3, "Task3 returns incorrect value.");
        }
    }
}
