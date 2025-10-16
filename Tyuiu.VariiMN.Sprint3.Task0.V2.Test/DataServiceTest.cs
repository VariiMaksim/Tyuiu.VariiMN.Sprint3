﻿using Tyuiu.VariiMN.Sprint3.Task0.V2.Lib;

namespace Tyuiu.VariiMN.Sprint3.Task0.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 9;
            double res = ds.GetMultiplySeries(startValue, stopValue);
            double wait = 0.021;

            Assert.AreEqual(wait, res);
        }
    }
}
