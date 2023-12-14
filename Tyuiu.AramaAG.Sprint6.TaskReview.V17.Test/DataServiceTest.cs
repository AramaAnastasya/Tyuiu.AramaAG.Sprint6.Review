using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AramaAG.Sprint6.TaskReview.V17.Lib;

namespace Tyuiu.AramaAG.Sprint6.TaskReview.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            int k = 1;
            int l = 4;
            int c = 0;
            DataService ds = new DataService();
            int[,] array = new int[5, 5]  { { 1, 2, 3, 4, 6},
                                            { 3, -54, 4, -6, 6},
                                            { 6, -4, 6, -4, 8 },
                                            { 5, -4, 4, -4, 2 },
                                            { 4, 9, 2, -1, 2 }};
            int res = ds.resultGetMatrix(array, c, k, l);
            int wait = 18;
            Assert.AreEqual(wait, res);
        }
    }
}
